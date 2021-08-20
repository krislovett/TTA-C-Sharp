using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public class Employee : Person, IQuittable
    {
        //inherit SayName method from Person class
        public override void SayName()
        {
            Console.WriteLine("Employee:");
            base.SayName();
        }

        //implement Quit from IQuittable interface
        public void Quit()
        {
            Console.WriteLine("This employee has put in their two weeks!");
        }
    }
}
