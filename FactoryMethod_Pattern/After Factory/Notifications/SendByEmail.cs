using FactoryMethod_Pattern.After_Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_Pattern.After_Factory.Notifications
{
    public class SendByEmail : INotification
    {
        public void Send(string user, string message) => Console.WriteLine($"Sending Email notification By {user}: {message}");
    }
    
}
