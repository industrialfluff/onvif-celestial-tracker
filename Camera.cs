using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CosineKitty;

namespace ONVIFCelestialTracker
{
    /// <summary>
    /// Camera information, GPS coordinates, etc.
    /// </summary>
    [Serializable]
    public class Camera
    {
        public string IP { get; set; }
        public string Name { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public Observer Location { get; set; }
        public bool IsActive { get; set; }
        public double Heading { get; set; } // which direction the physical center of the camera is facing, used for offset calculations
        public string Celestial { get; set; }
        public List<string> Addresses { get; set; }
    }

    /// <summary>
    /// The result to send to ONVIF for which azimuth and altitude to point at.
    /// </summary>
    public class CameraAngle
    {
        public double Azimuth { get; set; }
        public double Altitude { get; set; }
    }
}
