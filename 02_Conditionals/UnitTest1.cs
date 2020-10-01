using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _02_Conditionals
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Booleans()
        {
            bool isTrue = 17 > 5;
            bool isFalse = 17 == 4;
        }

        [TestMethod]
        public void IfElseStatements()
        {
            bool isTrue = true;
            if (true)
            {
                //do something more
            }
            int age = 12;
            if (age > 17)
            {
                Console.WriteLine("You're an adult");
            }
            else if (age > 6)
            {
                Console.WriteLine("You're a kid.");
            }
            else if (age > 0)
            {
                Console.WriteLine("You're far too young to be on a computer");
            }
            else
            {
                Console.WriteLine("You're not even born yet!");
            }
            if (age > 65 && age <18)
            {
                //and comparison &&
            }
            if (age <= 65 || age >= 18)
            {
                // or comparison ||
            }
            if (age == 17)
            {
                // is equal to
            }
            if (age != 19)
            {
                // Not equal to
                // ! bang operator
            }
        }

        [[TestMethod]
        public void SwitchCases()
        {
            int age = 42;

            switch(age)
            {
                case 18:
                    //code for if age is 18
                    break;
                case 19:
                    //code for if age is 19
                    break;
                case 20:
                    break;
                case 21:
                case 22:
                case 23:
                    //code here for 21-23
                    break;
                default:
                    //catch all code
                    Console.WriteLine("You are not 18-23");
                    break;

            }
        }]
        [[TestMethod]
        public void Ternaries()
        {
            int age = 37;
            //bool someVariable = (boolean statement) ? trueValue : falseValue;
            bool isAge = (age == 24) ? true : false;
        }
        {

        }]
    }
}
