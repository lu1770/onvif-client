using System;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using devicemgmt;
using media;
using ptz;
using PTZConfiguration = ptz.PTZConfiguration;
using PTZSpeed = ptz.PTZSpeed;
using Vector2D = ptz.Vector2D;

namespace ONVIFWinFormClient
{
    public class OVINFAgent
    {
        public string[] ConvertToChannels(Profile[] profiles)
        {
            return profiles.Select(p => p.Name).ToArray();
        }


        public async Task LoadProfiles(string ipAddress, string userName, string password)
        {
            var onvifUrl = GetOnvifUrl(ipAddress);
            Debug.WriteLine($"OnvifUrl {onvifUrl}");
            OnvifUrl = onvifUrl;
            HttpTransportBindingElement httpTransport = new HttpTransportBindingElement();
            httpTransport.AuthenticationScheme = AuthenticationSchemes.Digest;
            var binding =
                new CustomBinding(
                    new TextMessageEncodingBindingElement(MessageVersion.Soap12WSAddressing10, Encoding.UTF8),
                    httpTransport);
            DeviceClient device = new DeviceClient(binding, new EndpointAddress(onvifUrl));
            Service[] services = device.GetServices(false);
            Service xmedia2 =
                services.FirstOrDefault(s =>
                    s.Namespace == "http://www.onvif.org/ver10/media/wsdl"); //ver20改成ver10兼容性强
            this.Media = new MediaClient(binding, new EndpointAddress(xmedia2.XAddr));
            var digest = Media.ClientCredentials.HttpDigest;
            digest.ClientCredential = new NetworkCredential(userName, password);
            Profiles = Media.GetProfiles();
            pTZClient = new PTZClient(binding, new EndpointAddress(onvifUrl));
            pTZClient.ClientCredentials.HttpDigest.ClientCredential =
                new NetworkCredential(userName, password);
            await pTZClient.OpenAsync();
            ProfileToken = Profiles[1].token;
            pTZClient.GotoHomePosition(ProfileToken, new PTZSpeed() { PanTilt = new Vector2D() { x = 0, y = 0 } });
        }

        public MediaClient Media { get; set; }

        private static string GetOnvifUrl(string ipAddress)
        {
            var uri = $"http://{ipAddress}/onvif/device_service";
            var deviceUri = new UriBuilder(uri);
            string[] addr = ipAddress.Split(':');
            deviceUri.Host = addr[0];
            if (addr.Length == 2)
            {
                deviceUri.Port = Convert.ToInt16(addr[1]);
            }

            var onvifUrl = deviceUri.ToString();
            return onvifUrl;
        }

        public Profile[] Profiles { get; set; }

        public string OnvifUrl { get; set; }

        private bool Async = false;
        private static string DirectionSpace = "http://www.onvif.org/ver10/tptz/PanTiltSpaces/TranslationGenericSpace";
        private static string ZoomSpace = "http://www.onvif.org/ver10/tptz/ZoomSpaces/TranslationGenericSpace";
        private static float RedirectionSpeed = 1f;
        private static float ZoomSpeed = 1f;
        private static Vector2D DirectionLeft = new Vector2D() { x = -1 * RedirectionSpeed, y = 0 };
        private static Vector2D DirectionRight = new Vector2D() { x = RedirectionSpeed, y = 0 };
        private static Vector2D DirectionUp = new Vector2D() { x = 0, y = -1 * RedirectionSpeed };
        private static Vector2D DirectionDown = new Vector2D() { x = 0, y = RedirectionSpeed };

        private PTZClient pTZClient;
        private string ProfileToken;
        private string Timeout = "-1";

        public Task<ContinuousMoveResponse> ContinuousMoveAsync(Vector2D direction)
        {
            return pTZClient.ContinuousMoveAsync(ProfileToken, GetDirectionSpeed(direction), Timeout);
        }

        private static PTZSpeed GetDirectionSpeed(Vector2D direction)
        {
            return new ptz.PTZSpeed()
            {
                PanTilt = direction
            };
        }

        public void ContinuousMove(Vector2D direction)
        {
            if (pTZClient.State == CommunicationState.Opening)
            {
                return;
            }

            var timer = new Timer();
            timer.Start();
            pTZClient.ContinuousMove(ProfileToken, GetDirectionSpeed(direction), Timeout);
            timer.Stop();
            Debug.WriteLine($"timer.Interval {timer.Interval}");
        }

        public void MoveUp()
        {
            DoMove(DirectionUp);
        }

        private void DoMove(Vector2D direction)
        {
            if (Async)
            {
                ContinuousMoveAsync(direction);
            }
            else
            {
                ContinuousMove(direction);
            }
        }

        public void MoveDown()
        {
            DoMove(DirectionDown);
        }

        public void MoveLeft()
        {
            DoMove(DirectionLeft);
        }

        public void MoveRight()
        {
            DoMove(DirectionRight);
        }

        public void ZoomIn()
        {
            pTZClient.ContinuousMoveAsync(ProfileToken, GetZoomInSpeed(), Timeout);
        }

        private static PTZSpeed GetZoomInSpeed()
        {
            return new ptz.PTZSpeed()
            {
                Zoom = new ptz.Vector1D()
                {
                    x = -1 * ZoomSpeed,
                    space = ZoomSpace
                }
            };
        }

        public void ZoomOut()
        {
            pTZClient.ContinuousMoveAsync(ProfileToken, GetZoomOutSpeed(), Timeout);
        }

        private static PTZSpeed GetZoomOutSpeed()
        {
            return new ptz.PTZSpeed()
            {
                Zoom = new ptz.Vector1D()
                {
                    x = ZoomSpeed,
                    space = ZoomSpace
                }
            };
        }

        public void Stop()
        {
            if (pTZClient.State == CommunicationState.Opening)
            {
                return;
            }

            var timer = new Timer();
            timer.Start();
            pTZClient.Stop(ProfileToken, true, true);
            timer.Stop();
            Debug.WriteLine($"timer.Interval {timer.Interval}");
        }
    }
}