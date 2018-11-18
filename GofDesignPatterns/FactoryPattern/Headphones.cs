using System.Collections.Generic;

namespace FactoryPattern
{
    public class Headphones : ElectronicDevice
    {
        private List<string> operations;

        public Headphones(string name, string description)
            : base(name, description)
        {
            this.IsHasGarniture = false;
            this.operations = new List<string>();
        }

        // Derived classes could contain some additional functionality
        public bool IsHasGarniture { get; set; }

        public override IEnumerable<string> GetOperation()
        {
            // Some other logic is embed in the overrided method.
            this.SetOperations();
            return this.operations;
        }

        private void SetOperations()
        {
            if (this.operations != null)
            {
                if (this.IsHasGarniture)
                {
                    this.operations.Add("Speak using garniture.");
                }

                this.operations.Add("Listen music");
            }
        }
    }
}
