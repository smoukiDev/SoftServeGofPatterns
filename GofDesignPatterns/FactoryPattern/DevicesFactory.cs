using System;

namespace FactoryPattern
{
    public class DevicesFactory : IDeviceFactory
    {
        public DevicesFactory()
        {
            this.Name = "Device";
            this.Description = "Device description.";
        }

        public string Name { get; set; }

        public string Description { get; set; }

        /// <summary>
        /// Creates the device.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <returns>Instance of type.</returns>
        /// <exception cref="System.ArgumentException">Imposible to create instance.</exception>
        public ElectronicDevice CreateDevice(DeviceType type)
        {
            switch (type)
            {
                case DeviceType.AudioPlayer:
                    return new AudioPlayer(this.Name, this.Description);
                case DeviceType.Headphones:
                    return new Headphones(this.Name, this.Description);
                case DeviceType.Smartphone:
                    return new Smartphone(this.Name, this.Description);
                default:
                    throw new ArgumentException($"Imposible to create instance of type {type.ToString()}");
            }
        }
    }
}
