using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adaptor_Pattern.Before.Exeternal_Payment
{
    public class StripePayment
    {
        public void MakePayment(double amount, string currency)
        {
            Console.WriteLine($"Processing Stripe payment of {amount} {currency}");
        }
    }
}
