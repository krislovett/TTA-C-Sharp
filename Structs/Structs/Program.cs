using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            //create object of Number data type and print to console
            Number num = new Number();
            num.Amount = 42.3m;
            Console.WriteLine(num.Amount);
            Console.Read();
        }
    }
}
