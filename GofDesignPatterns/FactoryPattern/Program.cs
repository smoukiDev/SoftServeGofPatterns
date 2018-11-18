using System;

namespace FactoryPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            MusicDevicesFactory factory = new MusicDevicesFactory();
            factory.Name = "Sony Walkman";
            factory.Description = "SonyWalkman description.";
            ElectronicDevice device = factory.CreateDevice(DeviceType.AudioPlayer);
            Console.WriteLine(device.Name + "has functions:");
            foreach (var item in device.GetOperation())
            {
                Console.WriteLine(item);
            }

            factory.Name = "Beyerdinamics DT990";
            factory.Description = "For sound designers.";
            device = factory.CreateDevice(DeviceType.Headphones);
            Console.WriteLine(device.Name + "has functions:");
            foreach (var item in device.GetOperation())
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();

        }
    }
}
