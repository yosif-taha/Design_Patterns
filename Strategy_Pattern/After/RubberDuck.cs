using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern.After
{
    internal class RubberDuck : Duck
    {
        public override void Display() => Console.WriteLine("I am a rubber duck.");

        public RubberDuck() : base(new NoFly(), new Squawk())
        {
        }
       

    }
}
