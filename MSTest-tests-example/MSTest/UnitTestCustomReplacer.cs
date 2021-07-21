using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MSTest_tests_example.Basics;


namespace MSTest
{
    [TestClass]
    public class UnitTestCustomReplacer
    {
        [TestMethod]
        public void ChangeEverySelectedLetterByNumber()
        {

            // Arrange 
            CustomReplacer customReplacer = new CustomReplacer();
            string str = "Hello World";
            string charStr = "o";
            string result;

            //Act
           result = customReplacer.CustomReplace(str, charStr);


            //Assert

            Assert.AreEqual("Hell1 W2rld", result);



        }
    }
}
