using System.Collections.Generic;

namespace FactoryPattern
{
    /// <summary>
    /// Product abstraction.
    /// It could be interface as well.
    /// </summary>
    public abstract class ElectronicDevice
    {
        public ElectronicDevice(string name, string description)
        {
            this.Name = name;
            this.Description = description;
        }

        public string Name { get; set; }

        public string Description { get; set; }

        /// <summary>
        /// Some abstract method can be used.
        /// </summary>
        public abstract IEnumerable<string> GetOperation();
    }
}
