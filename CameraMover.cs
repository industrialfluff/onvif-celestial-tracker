using CosineKitty;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;


namespace ONVIFCelestialTracker
{
    public static class CameraMover
    {
        /// <summary>
        /// Calculate where to move the camera to.
        /// </summary>
        /// <param name="camera"></param>
        /// <param name="body"></param>
        /// <param name="frmLog"></param>
        public static void Move(Camera camera, Body body, FrmLog frmLog)
        {
            AstroTime time = new AstroTime(DateTime.Now);
            CameraAngle ca = GetCameraAngle(camera.Location, time, body);
            PTZControl control = new PTZControl(camera);

            // Take into account that the camera may not be physically facing due north
            ca.Azimuth += camera.Heading;
            if (ca.Azimuth > 360)
            {
                ca.Azimuth -= 360;
            }
            
            // Convert to -1.0 to 1.0 scale
            var x = (float)ca.Azimuth * 0.00278f;
            var y = (float)ca.Altitude * 0.00278f;
            frmLog.Log($"Moving {camera.Name} to follow {camera.Celestial} {x} {y}");
            try
            {
                control.MoveTo(x, y);
            }
            catch (Exception ex)
            {
                frmLog.Log(ex.Message);
            }
            
        }

        /// <summary>
        /// Calculate the angle from the camera to the celestial, taking into account camera bearing.
        /// </summary>
        /// <param name="observer"></param>
        /// <param name="time"></param>
        /// <param name="body"></param>
        /// <returns></returns>
        public static CameraAngle GetCameraAngle(Observer observer, AstroTime time, Body body)
        {
            CameraAngle cameraAngle = new CameraAngle();
            Equatorial equ_2000 = Astronomy.Equator(body, time, observer, EquatorEpoch.J2000, Aberration.Corrected);
            Equatorial equ_ofdate = Astronomy.Equator(body, time, observer, EquatorEpoch.OfDate, Aberration.Corrected);
            Topocentric hor = Astronomy.Horizon(time, observer, equ_ofdate.ra, equ_ofdate.dec, Refraction.Normal);
            cameraAngle.Azimuth = hor.azimuth;
            cameraAngle.Altitude = hor.altitude;
            return cameraAngle;
        }
    }
}
