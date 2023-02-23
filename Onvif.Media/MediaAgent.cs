using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using media;
using Onvif.DeviceManagement;

namespace Onvif.Media
{
    public class MediaAgent
    {
        public DeviceAgent Device { get; set; }

        public MediaAgent(DeviceAgent device)
        {
            Device = device;
            Load();
        }

        public string[] ConvertToChannels(Profile[] profiles)
        {
            return profiles?.Select(p => p.Name).ToArray();
        }

        public Profile[] GetProfiles()
        {
            return Media.GetProfiles();
        }

        private void Load()
        {
            var customBinding = Device.GetBinding();
            this.Media = new MediaClient(customBinding,
                new EndpointAddress(Device.GetXmedia2XAddr()));
            var digest = Media.ClientCredentials.HttpDigest;
            digest.ClientCredential = Device.Credential;
        }

        public string GetToken(int index = 0)
        {
            return GetProfiles()[index].token;
        }

        public MediaClient Media { get; set; }

        public UriBuilder GetRtspUri(string[] recordParams)
        {
            //UriBuilder uri = new UriBuilder(media.GetStreamUri("RtspOverHttp", profiles[listBox.SelectedIndex].token));

            StreamSetup streamSetup = new StreamSetup();
            streamSetup.Stream = StreamType.RTPUnicast; //"RTP-Unicast";
            streamSetup.Transport = new Transport();
            streamSetup.Transport.Protocol = TransportProtocol.UDP; //"UDP";

            // RTP/RTSP/UDP is not a special tunnelling setup (is not requiring)!
            //streamSetup.Transport.Tunnel = null;
            string mtoken = GetToken();

            MediaUri murl = Media.GetStreamUri(streamSetup, mtoken);
            //murl.Uri = murl.Uri.Replace("_", "&");
            string[] addr = murl.Uri.Split(':');

            if (addr.Length == 3)
            {
                // deviceUri.Port = Convert.ToInt16(addr[2]);
            }

            UriBuilder uri = new UriBuilder(murl.Uri);


            // uri.Host = deviceUri.Host;
            // uri.Port = deviceUri.Port;
            uri.Scheme = "rtsp";

            List<string> options = new List<string>();
            options.Add(":rtsp-http");
            options.Add(":rtsp-http-port=" + uri.Port);
            options.Add(":rtsp-user=" + Device.Credential.UserName);
            options.Add(":rtsp-pwd=" + Device.Credential.Password);
            options.Add(":network-caching=1000");
            if (recordParams.Length != 0)
            {
                foreach (string param in recordParams)
                {
                    options.Add(param);
                    Debug.WriteLine(param);
                }
            }

            //Uri uri2 = new Uri("rtsp://10.1.20.81:554/Streaming/Channels/101?transportmode=unicast&amp;profile=Profile_1");
            //Uri uri2 = new Uri("rtsp://10.1.20.80:554/cam/realmonitor?channel=1&amp;subtype=0&amp;unicast=true&amp;proto=Onvif");
            //vlcControl1.Play(uri2, options.ToArray());
            uri.UserName = Device.Credential.UserName;
            uri.Password = Device.Credential.Password;
            return uri;
        }

        public string[] GetChannels()
        {
            return ConvertToChannels(this.GetProfiles());
        }
    }
}