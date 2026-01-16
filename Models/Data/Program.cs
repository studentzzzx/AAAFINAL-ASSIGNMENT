using System;
using CodeFirstDemo.Data;
using CodeFirstDemo.Models;

namespace CodeFirstDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new StudentContext())
            {
                var student = new Student
                {
                    FirstName = "John",
                    LastName = "Doe",
                    EnrollmentDate = DateTime.Now
                };

                context.Students.Add(student);
                context.SaveChanges();

                Console.WriteLine("Student added successfully!");
                Console.ReadLine();
            }
        }
    }
}
