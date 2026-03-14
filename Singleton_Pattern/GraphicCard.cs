using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Pattern
{
    internal class GraphicCard
    {
        public int Data { get; set; }

        // 1. Constructor Must be Private
        private GraphicCard(int data)
        {
            Data = data;
        }

        public static GraphicCard Singleton = null!;

        // 2.1 Static Prop to create instance of the class

        public static GraphicCard SingletonObj { get; } = new GraphicCard(123);


        // 2.1 Static Method to create instance of the class
        static GraphicCard()
        {
            Singleton = new GraphicCard(512);
        }
        public static GraphicCard GetCard()
        {            
            return Singleton;
        }
    }
}
