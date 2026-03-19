using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adaptor_Pattern.Before
{
    public interface IPaymentProcessor
    {
        void ProcessPay(decimal amount, string currency);
    }
}
