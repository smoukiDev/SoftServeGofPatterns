using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    public class ManagerMediator : Mediator
    {
        public Colleague Customer { get; set; }
        public Colleague Programmer { get; set; }
        public Colleague Tester { get; set; }

        public override void Send(string message, Colleague colleague)
        {
            if (this.Customer == colleague)
            {
                // Customer is sedner
                // Programmer is receiver
                // Message to develop feature
                this.Programmer.Notify(message);
            }
            else if (this.Programmer == colleague)
            {
                // Programmer is sedner
                // Tester is receiver
                // Message to test feature
                this.Tester.Notify(message);
            }
            else if (this.Tester == colleague)
            {
                // Tester is sedner
                // Customer is receiver
                // Message that feature is complete
                this.Customer.Notify(message);
            }

        }
    }
}
