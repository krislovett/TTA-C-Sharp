using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Jim = new Employee();
            Jim.FirstName = "Jim";
            Jim.LastName = "Johnson";
            Jim.ID = 1000;

            Employee Tim = new Employee();
            Tim.FirstName = "Tim";
            Tim.LastName = "Johnson";
            Tim.ID = 1001;

            Employee Kim = new Employee();
            Kim.FirstName = "Kim";
            Kim.LastName = "Johnson";
            Kim.ID = 1000;

            //print whether employees have the same ID as bool
            Console.WriteLine(Jim == Kim);
            Console.WriteLine(Tim == Kim);
            Console.WriteLine(Jim != Tim);

            Console.Read();
        }
    }
}
