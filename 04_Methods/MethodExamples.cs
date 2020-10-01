﻿using System;
using System.ComponentModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _04_Methods
{
    [TestClass]
    public class MethodExamples
    {

        //Input
        //What we do
        //Output

        //access modifier...return type....method signature (name and list of parameters)

        public int AddTwoNumbers(int numOne, int numTwo)
        {
            int sum = numOne + numTwo;
            return sum;

        }

        private int SubtractTwoNumbers (int a, int b)
        {
            int num = a - b;
            return num;
        }

        private int MultiplyTwoNumbers (int x, int z)
        {
            int prod = x * z;
            return prod;
        }

        private int DivideTwoNumbers (int apricot, int cherry)
        {
            int fruitSalad = apricot / cherry;
            return fruitSalad;
        }

        private int FindRemainder (int a, int NumTwo)
        {
            int remainder = a % NumTwo;
            return remainder;
        }

        [TestMethod]
        public void MethodTests()
        {
            int banana = AddTwoNumbers(7, 12);
            Assert.AreEqual(19, banana);

            int subtractedBanana = SubtractTwoNumbers(10, 5);
            Assert.AreEqual(5, subtractedBanana);

            int product = MultiplyTwoNumbers(12, 5);
            Assert.AreEqual(60, product);

            int fruitSalad = DivideTwoNumbers(10, 4);
            Assert.AreEqual(2, fruitSalad);

            int remainder = FindRemainder(10, 4);
            Assert.AreEqual(2, remainder);
        }
    }
}
