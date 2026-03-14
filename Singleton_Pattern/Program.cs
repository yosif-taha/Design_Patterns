
namespace Singleton_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GraphicCard card1 = GraphicCard.SingletonObj;
            GraphicCard card2 = GraphicCard.SingletonObj;

            Console.WriteLine($"Graphic Card : {card1.Data}, Hash Code : {card1.GetHashCode()}");
            Console.WriteLine($"Graphic Card : {card2.Data}, Hash Code : {card2.GetHashCode()}");
        }
    }
}
