using CosineKitty;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONVIFCelestialTracker
{
    public static class CameraChecker
    {
        // Keep the reference to the log screen so logs can be seen.
        public static FrmLog frmLog;
        public static void CheckCameras(List<Camera> cameras)
        {
            // check to see if any celestial object is within range of a camera
            foreach (Camera camera in cameras)
            {
                Observer observer = camera.Location;
                AstroTime time = new AstroTime(DateTime.UtcNow);
                
                AstroTime marsrise = Astronomy.SearchRiseSet(Body.Mars, observer, Direction.Rise, time, 1.0);
                AstroTime marsset = Astronomy.SearchRiseSet(Body.Mars, observer, Direction.Set, time, 1.0);
                AstroTime venusrise = Astronomy.SearchRiseSet(Body.Venus, observer, Direction.Rise, time, 1.0);
                AstroTime venusset = Astronomy.SearchRiseSet(Body.Venus, observer, Direction.Set, time, 1.0);
                AstroTime saturnrise = Astronomy.SearchRiseSet(Body.Saturn, observer, Direction.Rise, time, 1.0);
                AstroTime saturnset = Astronomy.SearchRiseSet(Body.Saturn, observer, Direction.Set, time, 1.0);
                AstroTime jupiterrise = Astronomy.SearchRiseSet(Body.Saturn, observer, Direction.Rise, time, 1.0);
                AstroTime jupiterset = Astronomy.SearchRiseSet(Body.Saturn, observer, Direction.Set, time, 1.0);

                switch(camera.Celestial)
                {
                    case "Sun":
                        AstroTime sunrise = Astronomy.SearchRiseSet(Body.Sun, observer, Direction.Rise, time, 1.0);
                        AstroTime sunset = Astronomy.SearchRiseSet(Body.Sun, observer, Direction.Set, time, 1.0);
                        if (IsVisible(sunrise, sunset))
                        {
                            CameraMover.Move(camera, Body.Sun, frmLog);
                        }
                        break;
                    case "Moon":
                        AstroTime moonrise = Astronomy.SearchRiseSet(Body.Moon, observer, Direction.Rise, time, 1.0);
                        AstroTime moonset = Astronomy.SearchRiseSet(Body.Moon, observer, Direction.Set, time, 1.0);
                        if (IsVisible(moonrise, moonset))
                        {
                            CameraMover.Move(camera, Body.Moon, frmLog);
                        }
                        break;
                    default:
                        break;
                }
            }
        }

        private static bool IsVisible(AstroTime rise, AstroTime set)
        {
            return (rise.ToUtcDateTime() < set.ToUtcDateTime());
        }
    }
}
