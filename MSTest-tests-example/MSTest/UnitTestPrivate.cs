using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSTest_tests_example.Private;

namespace MSTest
{
  [TestClass]


    public class UnitTestPrivate
    {
        [TestMethod]
        public void CreateCorrectlyUserAndPassword()
        {
            string userId = "Anastasiia";
            string password = "11AAaaa";
            string passResult;

            LogonInfo logonInfo = new LogonInfo(userId, password);
            passResult = logonInfo.Password;

            Assert.AreEqual(password, passResult);


        }




    }
}
