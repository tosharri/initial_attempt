using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Inheritance
{
    abstract class Person
        // abstract class is general information that is never directly referenced in the methods
        //POLYMORPHISM through inheritance of this abstract (base) class that other classes inherit from
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public Person()
        {

        }
        public Person (string firstName, string lastName, string phoneNumber, string eMail)
        {
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Email = eMail;
        }
    }
    class Customer : Person
    {
        public bool IsPremium { get; set; }
        public Customer() { }
        public Customer(bool isPremium, string firstName, string lastName, string phoneNumber, string eMail)
            :base(firstName, lastName, phoneNumber, eMail)
        {
            IsPremium = isPremium;
        }
    }
    class Employee : Person
    {
        public int EmployeeNumber { get; set; }
        public DateTime HireDate { get; set; }
    }

    // creating new classes to designate between employee types
    class HourlyEmployee : Employee
    {
        public decimal HourlyWage { get; set; }
        public double Hours { get; set; }
    }
    class SalaryEmployee : Employee
    {
        public decimal Salary { get; set; }
    }
}
