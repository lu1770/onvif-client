﻿using System;
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
using Onvif.DeviceManagement;
using Onvif.Media;
using ptz;
using PTZConfiguration = ptz.PTZConfiguration;
using PTZSpeed = ptz.PTZSpeed;
using Vector2D = ptz.Vector2D;

namespace Onvif.PTZ
{
    public class PtzAgent
    {
        public DeviceAgent Device { get; set; }

        public PtzAgent(DeviceAgent device)
        {
            Device = device;
            LoadProfiles(device);
        }

        public Task LoadProfiles(DeviceAgent device)
        {
            var mediaAgent = new MediaAgent(device);
            ProfileToken = mediaAgent.GetToken();
            pTZClient = new PTZClient(device.GetBinding(), new EndpointAddress(device.GetXmedia2XAddr()));
            pTZClient.ClientCredentials.HttpDigest.ClientCredential = device.Credential;
            return pTZClient.OpenAsync();
        }

        private void GotoHomePosition()
        {
            pTZClient.GotoHomePosition(ProfileToken, new PTZSpeed() { PanTilt = new Vector2D() { x = 0, y = 0 } });
        }


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
            return new PTZSpeed()
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
            Zoom(GetZoomInSpeed());
        }

        private void Zoom(PTZSpeed speed)
        {
            if (Async)
            {
                pTZClient.ContinuousMoveAsync(ProfileToken, speed, Timeout);
            }
            else
            {
                pTZClient.ContinuousMove(ProfileToken, speed, Timeout);
            }
        }

        private static PTZSpeed GetZoomInSpeed()
        {
            return new PTZSpeed()
            {
                Zoom = new ptz.Vector1D()
                {
                    x = -1 * ZoomSpeed,
                }
            };
        }

        public void ZoomOut()
        {
            Zoom(GetZoomOutSpeed());
        }

        private static PTZSpeed GetZoomOutSpeed()
        {
            return new PTZSpeed()
            {
                Zoom = new ptz.Vector1D()
                {
                    x = ZoomSpeed,
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