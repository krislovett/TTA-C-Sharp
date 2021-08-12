using System;

namespace MathOperations
{
    class Program
    {
        static void Main()
        {
            //take input from user, convert to int, and multiply by 50
            Console.WriteLine("50 * ___ = ?");
            string times50string = Console.ReadLine();
            int times50 = Convert.ToInt32(times50string) * 50;
            Console.WriteLine("50 * " + times50string + " = " + times50);

            //take input from user, convert to int, add 25
            Console.WriteLine("25 + ___ = ?");
            string add25string = Console.ReadLine();
            int add25 = Convert.ToInt32(add25string) + 25;
            Console.WriteLine("25 + " + add25string + " = " + add25);

            //take input from user, convert to double, and divide by 12.5
            Console.WriteLine("___ / 12.5 = ?");
            string divide12string = Console.ReadLine();
            double divide12 = Convert.ToDouble(divide12string) / 12.5;
            Console.WriteLine(divide12string + " / 12.5 = " + divide12);

            //take input from user, convert to bool, and compare to 50
            Console.WriteLine("___ > 50 = ?");
            string greaterThan50string = Console.ReadLine();
            bool greaterThan50 = Convert.ToInt32(greaterThan50string) > 50;
            Console.WriteLine(greaterThan50string + " > 50 = " + greaterThan50);

            //take input from user, convert to int, divide by 7, and print remainder
            Console.WriteLine("___ % 7 = ?");
            string remainder7string = Console.ReadLine();
            int remainder7 = Convert.ToInt32(remainder7string) % 7;
            Console.WriteLine(remainder7string + " % 7 = " + remainder7);

            Console.Read();
        }
    }
}
