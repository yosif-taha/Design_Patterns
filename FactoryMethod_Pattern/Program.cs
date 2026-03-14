using FactoryMethod_Pattern.After_Factory.FactoryMethod;

namespace FactoryMethod_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter type (sms/email) :");
            var type = Console.ReadLine();

            Console.WriteLine("Please Enter Name of user :");
            var user = Console.ReadLine();

            Console.WriteLine("Please Enter Message :");
            var message = Console.ReadLine();


            #region Before Factory
            //if (type.ToLower() == "sms")
            //{
            //    var notification = new NotificationBySms();
            //    notification.Send(uder, message);
            //}
            //else if (type.ToLower() == "email")
            //{
            //    var notification = new NotificationByEmail();
            //    notification.Send(uder, message);
            //}
            //else
            //{
            //    Console.WriteLine("Please Enter The Type");
            //} 
            #endregion

            // After Factory
            NotificationFactory.CreateNotification(type).Send(user, message);
        }
    }
}
