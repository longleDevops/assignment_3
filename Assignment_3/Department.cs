using System;
namespace Assignment_3
{
    public class Department : IDepartmentService
    {
        public void AddDepartment(string departmentName)
        {
            Console.WriteLine($"Department {departmentName} added.");
        }
    }
}

