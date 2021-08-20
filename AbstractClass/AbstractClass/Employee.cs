using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public class Employee : Person
    {
        //inherit SayName method from Person class
        public override void SayName()
        {
            Console.WriteLine("Employee:");
            base.SayName();
        }
    }
}
