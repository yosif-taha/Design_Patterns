using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern.Before
{
    internal class RubberDuck : Duck
    {
        public override void Display() => Console.WriteLine("I am a Rubber Duck");

        public new void Quack()
        {
            Console.WriteLine("I am Squawking");
        }
        public new void Fly()
        {
            Console.WriteLine("No Wings To Fly");
        }

    }
}
