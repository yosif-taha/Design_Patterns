using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern.After
{
    public interface IQuickBehavior
    {
        public void PerformQuick();
    }

    class Quick : IQuickBehavior
    {
        public void PerformQuick() =>   Console.WriteLine("I am quickinng :");
        
    }

    class Squawk : IQuickBehavior
    {
        public void PerformQuick()
        {
            Console.WriteLine("I am Squawking :");
        }
    }
}
