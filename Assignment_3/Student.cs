using System;
namespace Assignment_3
{
    // Student class
    public class Student : Person, IStudentService
    {
        public Student(string name, DateTime dateOfBirth) : base(name, dateOfBirth)
        {
        }

        public string FullName
        {
            get { return Name; }
        }

        public void EnrollCourse(string courseName)
        {
            Console.WriteLine($"Student {Name} enrolled in {courseName} course.");
        }

        public override decimal CalculateSalary()
        {
            return 0; // Students do not have a salary
        }
    }
}



