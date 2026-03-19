using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adaptor_Pattern.Before
{
    public class PaymentService(IPaymentProcessor _paymentProcessor)
    {
        public void Pay(decimal amount, string currency)
        {
            _paymentProcessor.ProcessPay(amount,currency);
        }
    }
}
