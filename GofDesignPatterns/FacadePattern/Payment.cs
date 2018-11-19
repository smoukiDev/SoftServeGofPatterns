using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public class Payment : IPayment
    {
        public Payment(PaymentType type)
        {
            this.Type = type;
        }
        public PaymentType Type { get; }

        public bool VerifyPaymentDetails()
        {
            Console.WriteLine("Payment verification logic");
            return true;
        }
    }
}
