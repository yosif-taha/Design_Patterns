using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_Pattern.After_Factory.Interfaces
{
    public interface INotification
    {
        void Send(string user,string message);
    }
}
