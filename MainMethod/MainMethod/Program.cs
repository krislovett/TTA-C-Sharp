using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //create new numbers object
            Numbers numbers = new Numbers();

            //call on DoMath method and pass in int to return addResult
            Console.WriteLine("Please enter a whole number:");
            Console.WriteLine(numbers.DoMath(Convert.ToInt32(Console.ReadLine())));

            //call on DoMath method and pass in decimal to return divideResult
            Console.WriteLine("Please enter a decimal:");
            Console.WriteLine(numbers.DoMath(Convert.ToDecimal(Console.ReadLine())));

            //call on DoMath method and pass in string to return subtractResult
            Console.WriteLine("Please enter a whole number:");
            Console.WriteLine(numbers.DoMath(Console.ReadLine()));

            Console.Read();
        }
    }
}
