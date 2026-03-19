namespace Decorator_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Drink Espresso = new Espresso();
            Console.WriteLine(Espresso);

            Milk EspressoWithMilk = new Milk(Espresso);
            Console.WriteLine(EspressoWithMilk);

            Mocha EspressoWithMilkAndMocha = new Mocha(EspressoWithMilk);
            Console.WriteLine(EspressoWithMilkAndMocha);
        }
    }
}
