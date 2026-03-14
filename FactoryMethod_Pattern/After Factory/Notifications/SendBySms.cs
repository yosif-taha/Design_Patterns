using FactoryMethod_Pattern.After_Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace FactoryMethod_Pattern.After_Factory.Notifications
{
    public class SendBySms : INotification
    {
        public void Send(string user, string message) => Console.WriteLine($"Sending SMS notification By {user}: {message}");

    }
}
