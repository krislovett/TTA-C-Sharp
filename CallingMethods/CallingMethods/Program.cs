using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //create new numbers object
            Numbers numbers = new Numbers();
            Console.WriteLine("Please enter a whole number:");
            int inputNum = Convert.ToInt32(Console.ReadLine());

            //call on each Numbers method and print results
            Console.WriteLine(inputNum + " + " + numbers.AddNum + " = " +  numbers.AddNumbers(inputNum) + "\n");
            Console.WriteLine(inputNum + " - " + numbers.SubtractNum + " = " + numbers.SubtractNumbers(inputNum) + "\n");
            Console.WriteLine(inputNum + " * " + numbers.MultiplyNum + " = " + numbers.MultiplyNumbers(inputNum) + "\n");
            Console.Read();
        }
    }
}
