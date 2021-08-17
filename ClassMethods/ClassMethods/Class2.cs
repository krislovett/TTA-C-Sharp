using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethods
{
    static class Class2
    {
        //create static method that counts the characters in a string and outputs to stringLength1 variable
        public static void StringLength(string string1, out int stringLength1)
        {
            stringLength1 = Convert.ToInt32(string1.Length);
        }

        //overloads static method to optionally count and output characters in a second string
        public static void StringLength(string string1, out int stringLength1, string string2, out int stringLength2)
        {
            stringLength1 = Convert.ToInt32(string1.Length);
            stringLength2 = Convert.ToInt32(string2.Length);
        }
    }
}
