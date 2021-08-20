using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ID { get; set; }

        // override == operator to check if two employees have the same ID
        public static bool operator== (Employee employee1, Employee employee2)
        {
            bool employeeMatch = employee1.ID == employee2.ID;
            return employeeMatch;
        }

        // override != operator to check if two employees do not have the same ID
        public static bool operator!= (Employee employee1, Employee employee2)
        {
            bool employeeMatch = employee1.ID != employee2.ID;
            return employeeMatch;
        }
    }
}
