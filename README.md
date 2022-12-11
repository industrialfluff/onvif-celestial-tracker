# onvif-celestial-tracker

What does it do?  You have ONVIF PTZ cameras outside connected to a local network.  You'd like them to follow the sun, moon, Mars, Mercury, Venus, Jupiter, or Saturn.  Now you can do it.

Windows Desktop 6.0 application, requires .NET 7.0 runtime to operate.

Also requires 1+ ONVIF cameras on your network.  You must have the username and password for these cameras.  GPS location, elevation, and compass direction of where the middle of the base of the camera is required.  Since these are celestial bodies, they don't have to be too accurate.

Does not yet have the capability to zoom in.  Positions calculated by CosineKitty AstronomyEngine.

Every 5 minutes, updates each camera with the position of the celestial body selected.  If 'None', then the camera is ignored.

Will not update the camera if the object cannot be seen.

ONVIF camera detection by OnvifDiscovery 1.2.2

Icon by Icons8
