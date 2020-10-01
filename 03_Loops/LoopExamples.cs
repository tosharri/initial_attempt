﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _03_Loops
{
    [TestClass]
    public class LoopExamples
    {
        [TestMethod]
        public void ForLoops()
        {
            int studentCount = 15;
            //1 Starting Point
            //2 Condition that while true, keeps the loop running
            //3 What happens after each loop
            //4 Body of the loop, what happens each iteration
            // for //1          //2             //3
            for (int i = 0; i < studentCount; i++) //shorthand for i = i +1 -> i++
            {
                //4
                Console.WriteLine(i);
            }
        }
        [TestMethod]
        public void ForeachLoops()
        {
            string name = "Eleven Fifty Academy";
            //1 Collection that's being worked on
            //2 Name of the current iteration being used
            //3 current type in the collection
            //4 in keyword, used to seperate the individual and the collection
            //5 body of the loop

            //foreach //3  //2  //4 //1
            foreach (char letter in name)
            {
                Console.WriteLine(letter); //5
            }
        }
        [TestMethod]
        public void WhileLoops()
        {
            int total = 1;

            //1 loop runs while the condition is true
            //2 the body of the loop

            //while //1
            while (total != 30)
            {
                Console.WriteLine(total);
                total++; // total = total + 1
            }
        }
    }
}
