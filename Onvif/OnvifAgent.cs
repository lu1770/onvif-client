using System;
using devicemgmt;
using Onvif.DeviceManagement;
using Onvif.Media;
using Onvif.PTZ;

namespace Onvif
{
    public class OnvifAgent
    {
        public PtzAgent Ptz { get; set; }
        public MediaAgent Media { get; set; }
        public DeviceAgent Device { get; set; }

        public OnvifAgent(string ipAddress, string userName, string password)
        {
            Load(new DeviceAgent(ipAddress, userName, password));
        }

        public OnvifAgent(DeviceAgent device)
        {
            Load(device);
        }

        private void Load(DeviceAgent device)
        {
            Device = device;
            Media = new MediaAgent(device);
            Ptz = new PtzAgent(device);
        }
    }
}