using System;

namespace DailyReport
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");

            //ask what student's name is and save as a string
            Console.WriteLine("What is your name?");
            string studentName = Console.ReadLine();

            Console.WriteLine("What course are you on?");
            string currentCourse = Console.ReadLine();

            //ask what course page student is on and convert from string to integer
            Console.WriteLine("What page number?");
            string pageNumString = Console.ReadLine();
            int pageNum = Convert.ToInt32(pageNumString);

            //ask if student needs help and convert to boolean
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            string needHelpString = Console.ReadLine();
            bool needHelp = Convert.ToBoolean(needHelpString);

            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string positiveExp = Console.ReadLine();

            //ask how many hours student studied and convert to integer
            Console.WriteLine("How many hours did you study today?");
            string hoursStudiedString = Console.ReadLine();
            int hoursStudied = Convert.ToInt32(hoursStudiedString);

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            
            //keep console window open
            Console.Read();
        }
    }
}
