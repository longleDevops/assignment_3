using System;
namespace Assignment_3
{
    public class Instructor : Person, IInstructorService
    {
        public Instructor(string name, DateTime dateOfBirth) : base(name, dateOfBirth)
        {
        }

        public void AssignCourse(string courseName)
        {
            Console.WriteLine($"Instructor {Name} assigned to {courseName} course.");
        }

        public string FullName
        {
            get { return Name; }
        }

        public override decimal CalculateSalary()
        {
            return 50000; // Default salary for instructors
        }
    } 
}

