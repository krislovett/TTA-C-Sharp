using System;
using System.Linq;
using System.Data.Entity;
using System.Collections.Generic;

namespace FinalChallenge
{
    class Program
    {
        static void Main()
        {
            using (var db = new StudentContext())
            {
                var student = new Student() { Id = 1, FirstName = "Example", LastName = "Student", Grade = 11, GPA = 3.24m };
                db.Students.Add(student);
                db.SaveChanges();

                var query = from s in db.Students
                            orderby s.FirstName
                            select s;
                foreach (Student s in query)
                {
                    Console.WriteLine($"{s.FirstName} {s.LastName}\n" +
                        $"ID: {s.Id}\n" +
                        $"Grade: {s.Grade}\n" +
                        $"GPA: {s.GPA}");
                    Console.Read();
                }
            }
        }

        public class Student
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Grade { get; set; }
            public decimal GPA { get; set; }

            public virtual List<Student> Students { get; set; }
        }

        public class StudentContext : DbContext
        {
            public DbSet<Student> Students { get; set; }
        }
    }
}
