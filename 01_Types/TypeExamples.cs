using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_Types
{
    [TestClass]
    public class TypeExamples
    {
        [TestMethod]
        public void ValueTypes() //Pascal case is when all words start with capital letter
        {
            //--Whole Numbers
            byte oneBytesWorth;
            oneBytesWorth = 255;
            short smallWholeNumber = 16; //int16
            int wholeNumber = 32; //int32
            long largeWholeNumber = 64; //int64

            // Three main types for decimals
            float floatExample = 1.234567f; // always use an 'f' at the end of the number
            double doubleExample = 1.234999;  //
            decimal decimalExample = 3.2222m;

            //characters
            char letter = 'j'; //can be a letter, number or character

            //--Operators
            int numOne = 17; //--Camel case is when first word is all lowercase and second word is capitalized
            int numTwo = 5;

            int sum = numOne + numTwo;
            Console.WriteLine(sum);
            int diff = numOne - numTwo;
            Console.WriteLine(diff);
            int prod = numOne * numTwo;
            Console.WriteLine(prod);
            int quot = numOne / numTwo;
            Console.WriteLine(quot);
            int remainder = numOne % numTwo; //--called Modulus
            Console.WriteLine(remainder);

            Console.WriteLine("Hello");
        }

        [TestMethod]
        public void ReferenceTypes()
        {
            //--Strings - paragraphs or words put together to be used all at once
            string stringExample = "This is a string.";
            string name = "Joshua";
            string declared;
            declared = "now it is initialized";

            //--formatting strings

            string concatenate = stringExample + " " + name;  //This is a string. Joshua
            string interpolate = $"{name}. Here is the string: {stringExample}";  //Joshua. Here is the string: This is a string.
            Console.WriteLine(concatenate);
            Console.WriteLine(interpolate);

            //-- Other Object Examples
            DateTime now = DateTime.Now;
            Console.WriteLine(now);
            DateTime randomDate = new DateTime(2019, 6, 29);

            TimeSpan waitTime = randomDate - now;
            Console.WriteLine(waitTime.TotalSeconds);

            //-- Collections
            // Arrays
            string anotherExampleString = "Hello World";
            string[] stringArray = { anotherExampleString, "hello", "World", "!" };
            string[] students = new string[15];

            Console.WriteLine(stringArray);

            //Lists
            List<string> listOfStrings = new List<string>();
            listOfStrings.Add("Lawrence");

            //Queues
            Queue<string> firstInFirstOut = new Queue<string>();
            firstInFirstOut.Enqueue("Luke");

            //Dictionaries
            Dictionary<char, string> keyValuePair = new Dictionary<char, string>();
            keyValuePair.Add('j', "Josh");

            //Other Collections
            SortedList<int, string> sortedKeyValuePair = new SortedList<int, string>();
            Stack<string> firstInLastOut = new Stack<string>();
        }
    }
}
