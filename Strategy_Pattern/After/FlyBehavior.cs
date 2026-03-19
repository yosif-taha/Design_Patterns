using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern.After
{
    public interface IFlyBehavior
    {
       public void PerformFly();
    }

    class NormalFly : IFlyBehavior
    {
        public void PerformFly()
        {
            Console.WriteLine("I am flying normally.");
        }
    }

    class NoFly : IFlyBehavior
    {
        public void PerformFly()
        {
            Console.WriteLine("I can't fly.");
        }
    }
}
