using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public interface IPayment
    {
        PaymentType Type { get; }
        bool VerifyPaymentDetails();
    }
}
