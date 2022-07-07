namespace Counter.Services;

public enum DeviceOrientation
{
    Undefined,
    Landscape,
    Portrait
}

public interface IDeviceOrientationService
{
    DeviceOrientation GetOrientation();
}
