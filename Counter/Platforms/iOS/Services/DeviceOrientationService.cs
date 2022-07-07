using Counter.Services;
using UIKit;

namespace Counter.Platforms.iOS.Services;

public class DeviceOrientationService : IDeviceOrientationService
{
    public DeviceOrientation GetOrientation()
    {
#pragma warning disable CA1416 // Validar la compatibilidad de la plataforma
        UIInterfaceOrientation orientation = UIApplication.SharedApplication.StatusBarOrientation;
#pragma warning restore CA1416 // Validar la compatibilidad de la plataforma
        bool isPortrait = orientation == UIInterfaceOrientation.Portrait || orientation == UIInterfaceOrientation.PortraitUpsideDown;
        return isPortrait ? DeviceOrientation.Portrait : DeviceOrientation.Landscape;
    }
}