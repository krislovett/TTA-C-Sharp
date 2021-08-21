using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfTheWeek
{
    class Program
    {
        static void Main()
        {
            //ask user to enter today's day and assign to variable
            Console.WriteLine("Enter today's current day of the week:");
            string dayInput = Console.ReadLine().ToLower();

            try
            {
                //parse through user's input to find that value in the enum, then assign it to currentDay variable
                Days currentDay = (Days)Enum.Parse(typeof(Days), dayInput);
                Console.WriteLine("Success!");
            }
            catch (Exception)
            {
                //print error message if user inputs anything other than a day of the week
                Console.WriteLine("Please enter an acutal day of the week.");
            }

            Console.Read();
        }

        //create enum of days of the week
        public enum Days { monday, tuesday, wednesday, thursday, friday, saturday, sunday };
    }
}
