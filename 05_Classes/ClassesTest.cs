using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _05_Classes
{
    [TestClass]
    public class ClassesTests
    {
        [TestMethod]
        public void CookieTests()
        {
            Cookie cookie = new Cookie();           
            cookie.Name = "Snickerdoodle";
            cookie.HasNuts = false;
            Cookie anotherCookie = new Cookie();
            anotherCookie.Name = "Something else";
            cookie.GramsofFlour = 10;

            Cookie snickerdoodle = new Cookie("Snickerdoodle", false, 11.5);
            Cookie newCookie = new Cookie("Peanut Butter", true, 150);
        }
        [TestMethod]
        public void VehicleTests()
        {
            Vehicle car = new Vehicle();
            car.TypeofVehicle = VehicleType.Car;

            Vehicle newCar = new Vehicle
            {
                TypeofVehicle = VehicleType.Motorcycle, Make= "Honda", Model = "Civic"
            };
        }
        public DateTime GetAge (birthDate)
        {
            DateTime birthDate = new DateTime(1970,10,06);
            int age = ((DateTime.Now - birthDate).totalDays / 365.25D);
        }
    }
}
