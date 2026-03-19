using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern
{
    public abstract class Drink
    {
        public virtual string Description { get; set; } = null!;
        public virtual decimal Cost { get; set; }

        override public string ToString()
        {
            return $"{Description} -\n Cost : ${Cost}";
        }

    }

    class Espresso : Drink
    {
        public Espresso()
        {
            Description = "Coffee";
            Cost = 1.00m;
        }
    }

    class HouseBlend : Drink
    {
        public HouseBlend()
        {
            Description = "House Blend Coffee";
            Cost = 0.89m;
        }
    }

    class DarkRoast : Drink
    {
        public DarkRoast()
        {
            Description = "Dark Roast Coffee";
            Cost = 0.99m;
        }
    }

    class Decaf : Drink
    {
        public Decaf()
        {
            Description = "Decaf Coffee";
            Cost = 1.05m;
        }
    }

}
