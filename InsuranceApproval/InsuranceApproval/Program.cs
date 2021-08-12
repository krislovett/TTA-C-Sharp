using System;

namespace InsuranceApproval
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Insurance Approval");

            //ask for user's age, convert to int
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());

            //ask if user's had a DUI, convert to bool
            Console.WriteLine("Have you ever had a DUI? Please answer \"true\" or \"false\".");
            bool dui = Convert.ToBoolean(Console.ReadLine());

            //ask how many speeding tickets user has gotten
            Console.WriteLine("How many speeding tickets have you ever gotten?");
            int tickets = Convert.ToInt32(Console.ReadLine());

            //determine if user qualifies for insurance with && operators
            bool qualified = age >= 18 && dui == false && tickets <= 3;
            Console.WriteLine("Do you qualify for insurance? " + qualified);

            Console.Read();
        }
    }
}
