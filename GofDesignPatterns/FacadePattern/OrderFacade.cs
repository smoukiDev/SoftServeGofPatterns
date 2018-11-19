using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public class OrderFacade
    {
        private IShoppingCart<string> cart;
        private IOrder order;
        private IPayment payment;
        private IDelivery delivery;

        public OrderFacade(IShoppingCart<string> cart,
            IPayment payment, IDelivery delivery)
        {
            this.cart = cart;
            this.payment = payment;
            this.delivery = delivery;
        }

        public void AddGood(string good)
        {
            cart.AddItem(good);
        }

        public void RemoveGood(string good)
        {
            cart.RemoveItem(good);
        }

        public string PlaceOrder()
        {
            this.order = new Order();
        }
    }
}
