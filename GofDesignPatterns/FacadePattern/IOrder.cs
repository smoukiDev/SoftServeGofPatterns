using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public interface IOrder
    {
        string OrderId { get;}
        bool SendOrder();
    }
}
