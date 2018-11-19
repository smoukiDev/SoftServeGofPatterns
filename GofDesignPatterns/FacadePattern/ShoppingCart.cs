using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public class ShoppingCart : IShoppingCart<string>
    {
        private List<string> purchase;

        public ShoppingCart()
        {
            this.purchase = new List<string>();
        }

        public string AddItem(string item)
        {
            this.purchase.Add(item);
            return item;
        }

        public bool RemoveItem(string item)
        {
            bool result = false;
            string target = this.purchase.FirstOrDefault(p => p == item);
            if (target != null)
            {
                this.purchase.Remove(item);
                result = true;
            }

            return result;
        }
    }
}
