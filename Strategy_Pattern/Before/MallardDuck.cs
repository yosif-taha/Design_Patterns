using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern.Before
{
    internal class MallardDuck : Duck
    {
        public override void Display() => Console.WriteLine("I am a Mallard Duck");

    }
}
