using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClass
{
    class Class1
    {
        public Class1()
        {
        }

        //create void method that takes two ints as parameters. Add 2 to Num1 and print Num2 to console.
        public static void IntMethod(int Num1, int Num2)
        {
            int addResult = Num1 + 2;
            Console.WriteLine(Num2);
        }
    }
}
