using System;
namespace Assignment_3
{
    public class Course : ICourseService
    {
        public void AddCourse(string courseName)
        {
            Console.WriteLine($"Course {courseName} added.");
        }
    } 
}

