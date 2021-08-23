using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambdas
{
    class Program
    {
        static void Main(string[] args)
        {
            //create new list of employees
            List<Employee> employees = new List<Employee>();

            //populate new employee list
            Employee JaneW = new Employee() { FirstName = "Jane", LastName = "Watson", ID = 1 };
            employees.Add(JaneW);
            Employee ArthurR = new Employee() { FirstName = "Arthur", LastName = "Robinson", ID = 2 };
            employees.Add(ArthurR);
            Employee RuthB = new Employee() { FirstName = "Ruth", LastName = "Brooks", ID = 3 };
            employees.Add(RuthB);
            Employee EricB = new Employee() { FirstName = "Eric", LastName = "Bell", ID = 4 };
            employees.Add(EricB);
            Employee JoeG = new Employee() { FirstName = "Joe", LastName = "Gonzales", ID = 5 };
            employees.Add(JoeG);
            Employee MartinC = new Employee() { FirstName = "Martin", LastName = "Cox", ID = 6 };
            employees.Add(MartinC);
            Employee DeniseK = new Employee() { FirstName = "Denise", LastName = "Kelly", ID = 7 };
            employees.Add(DeniseK);
            Employee JoeT = new Employee() { FirstName = "Joe", LastName = "Turner", ID = 8 };
            employees.Add(JoeT);
            Employee LoisE = new Employee() { FirstName = "Lois", LastName = "Evans", ID = 9 };
            employees.Add(LoisE);
            Employee HugoH = new Employee() { FirstName = "Hugo", LastName = "Henderson", ID = 10 };
            employees.Add(HugoH);


            // add each employee with first name "joe" to separate list with a foreach loop
            //List<Employee> joes = new List<Employee>();
            //foreach (Employee employee in employees)
            //{
            //    if (employee.FirstName == "Joe")
            //    {
            //        joes.Add(employee);
            //    }
            //}

            // add each employee with first name "joe" to separate list with a lambda
            List<Employee> joes = employees.Where(x => x.FirstName == "Joe").ToList();

            // add each employee with id # greater than 5 to separate list with a lambda
            List<Employee> overFive = employees.Where(x => x.ID > 5).ToList();
        }
    }
}
