using System;
using System.Net;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Timers;
using OnvifMedia10;
using OnvifPTZService;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ONVIFCelestialTracker
{
    public class PTZControl
    {

        private MediaClient mediaClient;
        private PTZClient ptzClient;
        private Profile profile;
        private PTZConfigurationOptions options;
        private bool initialized = false;

        /// <summary>
        /// Initialize the PTZ controls for this camera.
        /// </summary>
        /// <param name="camera"></param>
        public PTZControl(Camera camera)
        {
            var uri = new Uri(camera.Addresses[0]);
            var baseUri = uri.GetLeftPart(System.UriPartial.Authority);

            var messageElement = new TextMessageEncodingBindingElement()
            {
                MessageVersion = MessageVersion.CreateVersion(EnvelopeVersion.Soap12, AddressingVersion.None)
            };
            HttpTransportBindingElement httpBinding = new HttpTransportBindingElement()
            {
                AuthenticationScheme = AuthenticationSchemes.Digest
            };
            CustomBinding bind = new CustomBinding(messageElement, httpBinding);
            mediaClient = new MediaClient(bind, new EndpointAddress($"{baseUri}/onvif/Media"));
            mediaClient.ClientCredentials.HttpDigest.ClientCredential.UserName = camera.User;
            mediaClient.ClientCredentials.HttpDigest.ClientCredential.Password = camera.Password;
            ptzClient = new PTZClient(bind, new EndpointAddress($"{baseUri}/onvif/PTZ"));
            ptzClient.ClientCredentials.HttpDigest.ClientCredential.UserName = camera.User;
            ptzClient.ClientCredentials.HttpDigest.ClientCredential.Password = camera.Password;

            var profs = mediaClient.GetProfiles();
            profile = mediaClient.GetProfile(profs[0].token);

            var configs = ptzClient.GetConfigurations();

            options = ptzClient.GetConfigurationOptions(configs[0].token);
        }


        /// <summary>
        /// Move to this point, synchronously.
        /// </summary>
        /// <param name="x">-1.0 to 1.0</param>
        /// <param name="y">-1.0 to 1.0</param>
        public void MoveTo(float x, float y)
        {
            OnvifPTZService.PTZSpeed velocity = new OnvifPTZService.PTZSpeed()
            {
                PanTilt = new OnvifPTZService.Vector2D()
                {
                    x = 0,
                    y = 0,
                    space = options.Spaces.RelativePanTiltTranslationSpace[0].URI
                },
                Zoom = new OnvifPTZService.Vector1D()
                {
                    space = options.Spaces.RelativeZoomTranslationSpace[0].URI
                }
            };

            PTZVector vector = new PTZVector()
            {
                PanTilt = new OnvifPTZService.Vector2D()
                {
                    x = x,
                    y = y,
                    space = options.Spaces.RelativePanTiltTranslationSpace[0].URI
                }
            };
            ptzClient.AbsoluteMove(profile.token, vector, velocity);
        }


        public void Stop()
        {
            ptzClient.Stop(profile.token, true, true);
        }
    }
}