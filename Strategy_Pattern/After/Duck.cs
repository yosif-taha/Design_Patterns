using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern.After
{
    public abstract class Duck
    {
       public abstract void Display();

        public IFlyBehavior FlyBehavior { get; set; }
        public IQuickBehavior QuickBehavior { get; set; }
        public Duck(IFlyBehavior flyBehavior,IQuickBehavior quickBehavior ) 
        {
            FlyBehavior = flyBehavior;
            QuickBehavior = quickBehavior;
        }


        public void Fly(Action flyBehavior)
        {
            //FlyBehavior.PerformFly();
            flyBehavior.Invoke();
        }

        public void Quick(Action qoickBehavior)
        {
            //QuickBehavior.PerformQuick();
            qoickBehavior.Invoke();
        }

        public void Swim()
        {
            Console.WriteLine("All ducks can swim.");
        }
    }
}
