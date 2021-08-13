using System;

namespace PackageExpress
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            
            Console.WriteLine("Please enter package weight (lbs):");
            decimal weight = Convert.ToDecimal(Console.ReadLine());

            //if package weight is over 50lbs, end program
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }

            //if weight is under 50lbs, ask for dimensions
            else
            {
                Console.WriteLine("Please enter package width (in):");
                decimal width = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Please enter package height (in):");
                decimal height = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Please enter package length (in):");
                decimal length = Convert.ToDecimal(Console.ReadLine());

                decimal totalDimensions = width + height + length;

                //if total dimensions are too large, end program
                if (totalDimensions > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                }

                //if total dimensions aren't too large, calculate shipping quote
                else
                {
                    decimal quote = ((width * height * length) * weight) / 100;
                    Console.WriteLine("Your estimated total for shipping this package is: $" + quote + ". Thank you!");
                }
            }

            Console.Read();
        }

    }
}
