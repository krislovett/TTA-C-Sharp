using System;
using System.Collections.Generic;

namespace ErrorHandling
{
    class Program
    {
        static void Main()
        {
            //try to take user input as int to divide by numbers from dividend list
            try
            {
                List<int> dividends = new List<int>() { 3, 54, 6, 11, 90 };
                Console.WriteLine("Enter a divisor.");
                int divisor = Convert.ToInt32(Console.ReadLine());

                foreach (int dividend in dividends)
                {
                    Console.WriteLine(dividend + " / " + divisor + " = " + (dividend / divisor));
                }
            }

            //display error message if input is formatted incorrectly
            catch (FormatException ex)
            {
                Console.WriteLine("Please enter a whole number.");
            }

            //display error message if input number is 0
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Cannot divide by zero.");
            }

            //catch any other errors
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("\nProgram completed.");
            Console.Read();
        }
    }
}
