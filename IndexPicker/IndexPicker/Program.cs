using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexPicker
{
    class Program
    {
        static void Main()
        {
            //create array of strings and have user pick an index. if index is greater than length of array, display error message
            string[] stringArray = { "Hello", "Hi", "Greetings", "Howdy" };
            Console.WriteLine("Pick an index (0-3):");
            int stringArrayIndex = Convert.ToInt32(Console.ReadLine());
            if (stringArrayIndex < stringArray.Length)
            {
                Console.WriteLine(stringArray[stringArrayIndex]);
            }
            else
            {
                Console.WriteLine("Index does not exist.");
            }

            //create array of integers and have user pick an index. if index is greater than length of array, display error message
            int[] intArray = { 24, 3, 82, 44, 523, 324};
            Console.WriteLine("Pick an index (0-5):");
            int intArrayIndex = Convert.ToInt32(Console.ReadLine());
            if (intArrayIndex < intArray.Length)
            {
                Console.WriteLine(intArray[intArrayIndex]);
            }
            else
            {
                Console.WriteLine("Index does not exist.");
            }

            //create list of strings and have user pick an index. if index is greater than count of list, display error message
            List<string> stringList = new List<string>();
            stringList.Add("Monday");
            stringList.Add("Tuesday");
            stringList.Add("Wednesday");
            stringList.Add("Thursday");
            stringList.Add("Friday");
            stringList.Add("Saturday");
            stringList.Add("Sunday");
            Console.WriteLine("Pick an index (0-6):");
            int stringListIndex = Convert.ToInt32(Console.ReadLine());
            if (stringListIndex < stringList.Count)
            {
                Console.WriteLine(stringList[stringListIndex]);
            }
            else
            {
                Console.WriteLine("Index does not exist.");
            }

            Console.Read();
        }
    }
}
