using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    //create abstract class Person
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //create virual method to print name
        public virtual void SayName()
        {
            Console.WriteLine("{0} {1}", FirstName, LastName);
        }
    }
}
