# onvif-celestial-tracker

Windows Desktop 6.0 application, requires .NET 7.0 runtime to operate.

Also requires 1+ ONVIF cameras on your network.  You must have the username and password for these cameras.  GPS location, elevation, and compass direction of where the middle of the base of the camera is required.  Since these are celestial bodies, they don't have to be too accurate.

Every 5 minutes, updates each camera with the position of the celestial body selected.  If 'None', then the camera is ignored.

Will not update the camera if the object cannot be seen.

Celestial position library by CosineKitty.

OnvifDiscovery 1.2.2

Icon by Icons8
