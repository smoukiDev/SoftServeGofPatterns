using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public class Delivery : IDelivery
    {
        public Delivery(DeliveryType type, string address)
        {
            this.Type = type;
            this.Address = address;
        }
        public DeliveryType Type { get; }

        public string Address { get; }

    }
}
