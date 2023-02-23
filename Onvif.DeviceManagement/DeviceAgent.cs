using System.Diagnostics;
using System.Linq;
using System.Net;
using System.ServiceModel.Channels;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using devicemgmt;
using Newtonsoft.Json;

namespace Onvif.DeviceManagement
{
    public class DeviceAgent:IDisposable
    {
        public DeviceAgent(string ipAddress, string userName, string password)
        {
            LoadProfiles(ipAddress, userName, password);
        }

        public static string GetOnvifUrl(string ipAddress)
        {
            Trace.Assert(!string.IsNullOrEmpty(ipAddress), "Ip address is not valid.");
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

        private void LoadProfiles(string ipAddress, string userName, string password)
        {
            Trace.Assert(!string.IsNullOrEmpty(ipAddress), "Ip address is not valid.");
            Trace.Assert(!string.IsNullOrEmpty(userName), "User name is not valid.");
            Trace.Assert(!string.IsNullOrEmpty(password), "Password is not valid.");
            OnvifUrl = GetOnvifUrl(ipAddress);
            Trace.WriteLine($"OnvifUrl {OnvifUrl}");
            DeviceClient device = new DeviceClient(GetBinding(), new EndpointAddress(OnvifUrl));
            Credential = new NetworkCredential(userName, password);
            device.ClientCredentials.HttpDigest.ClientCredential = Credential;
            Device = device;
            Service[] services = Device.GetServices(false);
            XAddrDictionary = services.ToDictionary(t => t.Namespace, t => t.XAddr);
        }

        public string GetXmedia2XAddr()
        {
            return XAddrDictionary[XAddrNamespace.Ver10.MEDIA];
        }

        public Dictionary<string, string> XAddrDictionary { get; set; }

        public DeviceClient Device { get; set; }

        public NetworkCredential Credential { get; set; }

        public CustomBinding GetBinding()
        {
            HttpTransportBindingElement httpTransport = new HttpTransportBindingElement();
            httpTransport.AuthenticationScheme = AuthenticationSchemes.Digest;
            var binding =
                new CustomBinding(
                    new TextMessageEncodingBindingElement(MessageVersion.Soap12WSAddressing10, Encoding.UTF8),
                    httpTransport);
            return binding;
        }

        public string OnvifUrl { get; set; }

        public void Dispose()
        {
            Device.Close();
            ((IDisposable)Device)?.Dispose();
            Device = null;
            Credential = null;
            XAddrDictionary = null;
        }
    }
}