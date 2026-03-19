using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern.After
{
    internal class MallardDuck : Duck
    {
        public override void Display() => Console.WriteLine("I am a mallard duck.");

        public MallardDuck() : base(new NormalFly(), new Quick())
        {
        }
       

    }
}
