using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern.Before
{
    public abstract class Duck
    {
        public abstract void Display();
        public void Swim()
        {
            Console.WriteLine("I am Swamming");
        }
        public void Quack()
        {
            Console.WriteLine("I am Quacking");
            Console.Beep(450,2000);
        }
        public void Fly()
        {
            Console.WriteLine("I am Flying");
        }

    }
}
