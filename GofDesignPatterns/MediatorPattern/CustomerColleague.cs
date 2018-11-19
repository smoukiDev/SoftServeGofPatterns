using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    public class CustomerColleague : Colleague
    {
        public CustomerColleague(Mediator mediator)
            : base(mediator)
        { }

        public override void Notify(string message)
        {
            Console.WriteLine("Message to customer: " + message);
        }
    }
}
