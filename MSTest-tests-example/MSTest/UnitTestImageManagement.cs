using System;
using System.Collections.Generic;
using System.Text;
using Moq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSTest_tests_example.Mocks.Date;




namespace MSTest
{
    [TestClass]
    public class UnitTestImageManagement
    {
        [TestMethod]
        public void SelectImageByTheTime()
        {
            Mock<ImageManagement> imageM = new Mock<ImageManagement>();
            imageM.Setup(x => x.setTime()).Returns(12);

            ImageManagement imageManagement = new ImageManagement();
            Assert.AreEqual(imageManagement.GetImageForTimeOfDay(),"sun.jpg");
           
            
            //// Arrenge
            //ImageManagement imageManagement = new ImageManagement();
            //int currentHour = 12;
            //string result;
            //string sunImage = "sun.jpg";

            ////Act

            //result = imageManagement.GetImageForTimeOfDay();

            ////Asser

            //Assert.AreEqual(sunImage, result);


        }

    }
}
