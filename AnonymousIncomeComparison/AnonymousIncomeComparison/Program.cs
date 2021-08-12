using System;

namespace AnonymousIncomeComparison
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");

            //have user input person 1's hourly rate and hours worked, and calculate annual salary
            Console.WriteLine("Person 1:");
            Console.WriteLine("Hourly rate?");
            decimal person1rate = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            decimal person1hours = Convert.ToDecimal(Console.ReadLine());
            decimal person1salary = person1rate * (person1hours * 52);

            //have user input person 2's hourly rate and hours worked, and calculate annual salary
            Console.WriteLine("Person 2:");
            Console.WriteLine("Hourly rate?");
            decimal person2rate = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            decimal person2hours = Convert.ToDecimal(Console.ReadLine());
            decimal person2salary = person2rate * (person2hours * 52);

            //print person 1 and person 2's annual salaries and which one makes more
            Console.WriteLine("Person 1's annual salary: $" + person1salary);
            Console.WriteLine("Person 2's annual salary: $" + person2salary);
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(person1salary > person2salary);

            Console.Read();
        }
    }
}
