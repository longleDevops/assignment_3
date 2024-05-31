using System;
namespace Assignment_3
{
    // Interfaces
    public interface IPersonService
    {
        decimal CalculateSalary();
        int CalculateAge();
        List<string> GetAddresses();
    }

    public interface IStudentService : IPersonService
    {
        void EnrollCourse(string courseName);
    }

    public interface IInstructorService : IPersonService
    {
        void AssignCourse(string courseName);
    }

    public interface ICourseService
    {
        void AddCourse(string courseName);
    }

    public interface IDepartmentService
    {
        void AddDepartment(string departmentName);
    }
}

