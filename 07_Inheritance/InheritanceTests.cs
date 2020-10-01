﻿using System;
using System.Collections.Generic;
using System.Globalization;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _07_Inheritance
{
    [TestClass]
    public class InheritanceTests
    {
        [TestMethod]
        public void PersonExamples()
        {
            //var person = new Person();
            //person.FirstName = "Joshua";
            //person.ToString();

            var customer = new Customer(true, "Josh", "Tucker", "123456789", "jtucker@elevenfifty.org");
            customer.ToString();
            customer.FirstName = "Lawrence";
            customer.IsPremium = true;

            var employee = new Employee();
            employee.FirstName = "Luke";
            employee.HireDate = DateTime.Today;

            var hourlyEmployee = new HourlyEmployee();


            List<Person> people = new List<Person>();
            people.Add(customer);
            people.Add(employee);
            people.Add(hourlyEmployee);
        }
    }
}
