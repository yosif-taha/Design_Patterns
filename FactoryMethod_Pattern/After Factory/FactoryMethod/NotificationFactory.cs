using FactoryMethod_Pattern.After_Factory.Interfaces;
using FactoryMethod_Pattern.After_Factory.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_Pattern.After_Factory.FactoryMethod
{
    public class NotificationFactory
    {
        public static INotification CreateNotification(string type)
        {
            return type.ToLower() switch
            {
                "email" => new SendByEmail(),
                "sms" => new SendBySms(),
                _ => throw new ArgumentException("Invalid notification type")
            };
        }
    }
}
