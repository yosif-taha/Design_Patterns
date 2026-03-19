using Strategy_Pattern.After;

namespace Strategy_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //BEFORE

            //MallardDuck mallard = new MallardDuck();
            //mallard.Display();
            //mallard.Fly();
            //mallard.Quack();
            //mallard.Swim();

            //Console.WriteLine();
            //Console.WriteLine("***********************************");
            //Console.WriteLine();

            //RubberDuck rubberDuck = new RubberDuck();
            //rubberDuck.Display();
            //rubberDuck.Fly();
            //rubberDuck.Quack();
            //rubberDuck.Swim();

            //AFTER
            After.MallardDuck mallard = new After.MallardDuck();
            mallard.Display();
            //mallard.Fly(() => Console.WriteLine("I am Flying :")); //  use anynomus method  : we can easily change the behavior of the duck by changing the implementation of the fly and quick behavior
            mallard.Fly(new NormalFly().PerformFly);
            //mallard.Quick(() => Console.WriteLine("I am quickinng :")); //  use anynomus method  : we can easily change the behavior of the duck by changing the implementation of the fly and quick behavior
            mallard.Quick(new Quick().PerformQuick);
            mallard.Swim();

            Console.WriteLine();
            Console.WriteLine("***********************************");
            Console.WriteLine();

            After.RubberDuck rubberDuck = new After.RubberDuck();
            rubberDuck.Display();
            rubberDuck.Fly(new NoFly().PerformFly);
            rubberDuck.Quick(new Squawk().PerformQuick);
            rubberDuck.Swim();
        }
    }
}
