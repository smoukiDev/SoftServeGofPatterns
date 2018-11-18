using System.Collections.Generic;

namespace FactoryPattern
{
    /// <summary>
    /// Concrete product.
    /// </summary>
    public class AudioPlayer : ElectronicDevice
    {
        private const string DEFAULT_FORMAT = "mp3";

        private List<string> operations;

        public AudioPlayer(string name, string description)
            : base(name, description)
        {
            this.SupportedFormats = new List<string>() { DEFAULT_FORMAT };
            this.operations = new List<string>();
            this.SetOperations();
        }

        // Derived classes could contain some additional functionality
        public List<string> SupportedFormats { get; private set; }

        public override IEnumerable<string> GetOperation()
        {
            return this.operations;
        }

        private void SetOperations()
        {
            if (this.operations != null)
            {
                this.operations.Add("Listen music");
                this.operations.Add("Overview tracks tags");
            }
        }
    }
}
