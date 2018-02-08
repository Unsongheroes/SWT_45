using SimpleCalculator;

namespace Calculator.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleCalculator1 calc = new SimpleCalculator1();

            double test1 = calc.Add(5, 2);

            System.Console.WriteLine("test1: test Add(5,2) result: {0}", test1);

            double test2 = calc.Subtract(7, 17);

            System.Console.WriteLine("test1: test subtract(7,17) result: {0}", test2);

            double test3 = calc.Power(2, 5);

            System.Console.WriteLine("test1: test power(2,5) result: {0}", test3);

            double test4 = calc.Multiply(3, 7);

            System.Console.WriteLine("test1: test Multiply(3,7) result: {0}", test4);


        }
    }
}
