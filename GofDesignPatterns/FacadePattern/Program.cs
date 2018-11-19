using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IPayment payment = new Payment(PaymentType.Cash);
            IDelivery delivery = new Delivery(DeliveryType.PostOffice, "Gagarina street, 31, Dnipro, Ukraine");
            OrderFacade orderFacade = new OrderFacade(payment, delivery);
            orderFacade.AddGood("Phone");
            orderFacade.AddGood("Speakers");
            orderFacade.RemoveGood("Speakers");
            orderFacade.AddGood("Headphones");
            string id = orderFacade.PlaceOrder();
            Console.WriteLine($"Order №{id} will be delivered by adress");
            Console.WriteLine($"{delivery.Address} using {delivery.Type} type of delivery.");
            Console.WriteLine("Order goods:");
            Console.ReadLine();
        }
    }
}
