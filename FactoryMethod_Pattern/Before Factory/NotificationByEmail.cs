using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_Pattern.Before_Factory
{
    public class NotificationByEmail
    {
        public void Send(string user, string message)
        {
            Console.WriteLine($"Sending Email notification By {user}: {message}");
        }
    }
}
