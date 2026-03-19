using Adaptor_Pattern.Before;
using Adaptor_Pattern.Before.Exeternal_Payment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adaptor_Pattern.After
{
    public class StripeAdaptor(StripePayment _stripePayment) : IPaymentProcessor
    {
        public void ProcessPay(decimal amount, string currency)
        {
            _stripePayment.MakePayment( (double) amount, currency);
        }
    }
}
