using Adaptor_Pattern.After;
using Adaptor_Pattern.Before;
using Adaptor_Pattern.Before.Exeternal_Payment;

namespace Adaptor_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// BEFORE
            //var localPayment = new LocalPayment();
            //var stripePayment = new StripePayment();

            //var payment = new PaymentService(stripePayment); // error : PaymentService expects an IPaymentProcessor, but StripePayment does not implement it
            //payment.Pay(100, "USD");

            // AFTER

            var localPayment = new LocalPayment();
            var stripePayment = new StripePayment();

            var adapter = new StripeAdaptor(stripePayment); // Create an adapter that wraps the StripePayment

            var payment = new PaymentService(adapter);  // Now we can use the adapter to process the payment through the PaymentService
            payment.Pay(100, "USD");
        }
    }
}
