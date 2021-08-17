using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee SampleStudent = new Employee() { FirstName = "Sample", LastName = "Student" };

            //call SayName superclass method from Person class
            SampleStudent.SayName();

            Console.Read();
        }
    }
}
