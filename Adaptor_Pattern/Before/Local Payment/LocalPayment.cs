using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adaptor_Pattern.Before
{
    public class LocalPayment : IPaymentProcessor
    {
        public void ProcessPay(decimal amount, string currency) =>  Console.WriteLine($"Processing local payment of {amount} {currency}");

    }
}
