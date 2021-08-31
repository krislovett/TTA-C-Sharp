using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace FinalChallenge
{
    class Program
    {
        static void Main()
        {
            using (var db = new StudentContext(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Users\Kris\Documents\GitHub\TTA-C-Sharp\FinalChallenge\FinalChallenge\App_Data\FinalChallenge.mdf;Integrated Security=True"))
            {
                var student = new Student() { Id = 1, FirstName = "Test", LastName = "Student", Grade = 11, GPA = 3.24m };
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
            public StudentContext(string connectionString)
                : base(connectionString) { }
            public DbSet<Student> Students { get; set; }
        }
    }
}
