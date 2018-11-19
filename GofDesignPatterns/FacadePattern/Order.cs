using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public class Order : IOrder
    {
        public Order()
        {
            this.OrderId = Guid.NewGuid().ToString();
        }

        public string OrderId { get; }

        public bool SendOrder()
        {
            Console.WriteLine("Send order logic");
            return true;
        }
    }
}
