using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 Class1 = new Class1();

            //call IntMethod, passing in two ints
            Class1.IntMethod(5, 10);

            //call IntMethod, passing in two ints by name
            Class1.IntMethod(Num1: 12, Num2: 13);

            Console.Read();
        }
    }
}
