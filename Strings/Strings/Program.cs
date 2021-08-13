using System;
using System.Text;

namespace Strings
{
    class Program
    {
        static void Main()
        {
            //concatenate three strings into one and convert it to uppercase
            string string1 = "A ";
            string string2 = "concatenated ";
            string string3 = "string.";
            string bigString = (string1 + string2 + string3).ToUpper();
            Console.WriteLine(bigString);

            //create a stringbuilder and append new sentences to make a paragraph.
            StringBuilder sb = new StringBuilder("Lorem ipsum dolor sit amet, consectetur adipiscing elit. ");
            sb.Append("Vestibulum rhoncus arcu et sodales auctor. ");
            sb.Append("Vivamus eget nisi ipsum.");
            Console.WriteLine(sb);

            Console.Read();
        }
    }
}
