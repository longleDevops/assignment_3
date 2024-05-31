using System;
namespace Assignment_3
{
    // Abstract class
    public abstract class Person
    {
        protected string Name { get; set; }
        protected DateTime DateOfBirth { get; set; }
        protected decimal Salary { get; set; }
        protected List<string> Addresses { get; set; }

        public Person(string name, DateTime dateOfBirth)
        {
            Name = name;
            DateOfBirth = dateOfBirth;
            Addresses = new List<string>();
        }

        public int CalculateAge()
        {
            return DateTime.Now.Year - DateOfBirth.Year;
        }

        public List<string> GetAddresses()
        {
            return Addresses;
        }

        public abstract decimal CalculateSalary();
    }
}

