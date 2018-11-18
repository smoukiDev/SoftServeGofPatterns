namespace FactoryPattern
{
    /// <summary>
    /// Creator abstraction.
    /// Contains factory method.
    /// It could be abstract class as well.
    /// </summary>
    public interface IDeviceFactory
    {
        ElectronicDevice CreateDevice(DeviceType type);
    }
}
