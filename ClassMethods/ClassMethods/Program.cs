using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 Class1 = new Class1();

            Console.WriteLine("Enter a whole number.");
            int dividend = Convert.ToInt32(Console.ReadLine());

            //call Divide method from Class1 an divide user's number by 2
            Class1.Divide(dividend);

            //have user enter a string and set value to string1
            Console.WriteLine("Enter a word or phrase.");
            string string1 = Console.ReadLine();

            //have user optionally enter a second string and set to string2
            Console.WriteLine("Enter another word or phrase (optional).");
            string string2 = Console.ReadLine();

            //declare stringLength variables for StringLength method to output to
            int stringLength1;
            int stringLength2;

            //if string2 is empty, only pass string1 to StringLength
            if (string2 == "")
            {
                Class2.StringLength(string1, out stringLength1);
                Console.WriteLine("\"{0}\" is {1} characters long.", string1, stringLength1);
            }
            //if string2 is not empty, pass both strings to StringLength
            else if (string2 != "")
            {
                Class2.StringLength(string1, out stringLength1, string2, out stringLength2);
                Console.WriteLine("\"{0}\" is {1} characters long.", string1, stringLength1);
                Console.WriteLine("\"{0}\" is {1} characters long.", string2, stringLength2);
            }

            Console.Read();
        }
    }
}
