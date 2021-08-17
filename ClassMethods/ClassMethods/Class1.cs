using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethods
{
    class Class1
    {
        public Class1()
        {
            divisor = 2;
        }

        public int divisor { get; set; }

        //divide user input number by 2
        public void Divide(int dividend)
        {
            Console.WriteLine("{0} / {1} = " + dividend / divisor, dividend, divisor);
        }
    }
}
