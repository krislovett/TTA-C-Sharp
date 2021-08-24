using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time
{
    class Program
    {
        static void Main(string[] args)
        {
            //print current date and time to console
            Console.WriteLine("Current time: " + DateTime.Now);

            //ask user to input a number and save to num
            Console.WriteLine("Enter a number.");
            int num = Convert.ToInt32(Console.ReadLine());

            //add num hours to current time and print new time
            DateTime newTime = DateTime.Now.AddHours(num);
            Console.WriteLine("In {0} hours, it will be: {1}", num, newTime);


            Console.Read();
        }
    }
}
