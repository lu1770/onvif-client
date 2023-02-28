using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using media;
using Onvif.DeviceManagement;

namespace Onvif.Media
{
    public class MediaAgent : IDisposable
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
            Media = new MediaClient(customBinding,
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
            var streamSetup = new StreamSetup();
            streamSetup.Stream = StreamType.RTPUnicast; //"RTP-Unicast";
            streamSetup.Transport = new Transport();
            streamSetup.Transport.Protocol = TransportProtocol.UDP; //"UDP";

            var mtoken = GetToken();

            var murl = Media.GetStreamUri(streamSetup, mtoken);
            //murl.Uri = murl.Uri.Replace("_", "&");
            var addr = murl.Uri.Split(':');

            if (addr.Length == 3)
            {
                // deviceUri.Port = Convert.ToInt16(addr[2]);
            }

            var uri = new UriBuilder(murl.Uri);

            uri.Scheme = "rtsp";

            var options = new List<string>();
            options.Add(":rtsp-http");
            options.Add(":rtsp-http-port=" + uri.Port);
            options.Add(":rtsp-user=" + Device.Credential.UserName);
            options.Add(":rtsp-pwd=" + Device.Credential.Password);
            options.Add(":network-caching=1000");
            if (recordParams.Length != 0)
            {
                foreach (var param in recordParams)
                {
                    options.Add(param);
                    Debug.WriteLine(param);
                }
            }

            uri.UserName = Device.Credential.UserName;
            uri.Password = Device.Credential.Password;
            uri.Query = string.Join("&", options);
            return uri;
        }

        public string[] GetChannels()
        {
            return ConvertToChannels(GetProfiles());
        }

        public void Dispose()
        {
            Media.Close();
            ((IDisposable)Media)?.Dispose();
            Device = null;
            Media = null;
        }
    }
}