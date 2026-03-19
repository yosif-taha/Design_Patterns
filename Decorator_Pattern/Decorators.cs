using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern
{
    abstract class Decorator : Drink
    {
        private protected Drink _drink;
        protected Decorator(Drink drink) 
        {
         _drink = drink;
        }
    }
    class Milk : Decorator
    {    
        public Milk(Drink drink) : base(drink)
        { 
        }

        public override string Description => $"{_drink.Description}, Milk";
        public override decimal Cost => _drink.Cost + 0.10m;
    }
    class Mocha : Decorator
    {
  
        public Mocha(Drink drink): base(drink)
        {
           
        }
        public override string Description => $"{_drink.Description}, Mocha";
        public override decimal Cost => _drink.Cost + 0.20m;
    }
    class Soy : Decorator
    {

        public Soy(Drink drink) : base(drink)
        {
     
        }
        public override string Description => $"{_drink.Description}, Soy";
        public override decimal Cost => _drink.Cost + 0.15m;
    }
    class Whip : Decorator
    {

        public Whip(Drink drink) : base(drink)
        {

        }
        public override string Description => $"{_drink.Description}, Whip";
        public override decimal Cost => _drink.Cost + 0.10m;
    }
}
