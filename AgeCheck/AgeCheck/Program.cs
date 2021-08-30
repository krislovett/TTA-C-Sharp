using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age:");

            //try to take user input for age and set to int, then print to console.
            try
            {
                int age = Convert.ToInt32(Console.ReadLine());
                
                //if age is a negative number, throw error
                if (age < 0)
                {
                    throw new ArgumentException();
                }
                Console.WriteLine("Your age is: {0}", age);
                Console.Read();
            }

            //catch exception for negative age and print error message
            catch (ArgumentException)
            {
                Console.WriteLine("Age cannot be negative.");
                Console.Read();
                return;
            }

            //catch any other exceptions and print error message
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.Read();
                return;
            }
        }
    }
}
