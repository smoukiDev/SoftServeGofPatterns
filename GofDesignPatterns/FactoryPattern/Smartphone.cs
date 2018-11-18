using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    /// <summary>
    /// Concrete product.
    /// </summary>
    public class Smartphone : ElectronicDevice
    {
        private List<string> operations;

        public Smartphone(string name, string description)
            : base(name, description)
        {
            this.IsDualSim = false;
            this.operations = new List<string>();
            this.SetOperations();
        }

        // Derived classes could contain some additional functionality.
        public bool IsDualSim { get; set; }

        public override IEnumerable<string> GetOperation()
        {
            return this.operations;
        }

        private void SetOperations()
        {
            if (this.operations != null)
            {
                this.operations.Add("Make calls");
                this.operations.Add("Use GPS");
                this.operations.Add("Use the Internet");
                this.operations.Add("Listen music");
            }
        }
    }
}
