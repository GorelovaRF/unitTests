using System;
using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSTest_tests_example.Mocks.Date;
using MSTest_tests_example.Mocks;

namespace EjercicioSpecFlow
{
    [Binding]
    public class ImageManagementSteps
    {
        ImageManagement imageManagement = null;
       
        int currentHour;
        string result = null;
        string sunImage = "sun.jpg";


        [Given(@"its (.*) o'clock")]
        public void GivenItsOClock(int p0)
        {
            imageManagement = new ImageManagement();
            
            currentHour = p0;

        }
        
        [When(@"by the condition will be selected the sun image")]
        public void WhenByTheConditionWillBeSelectedTheSunImage()
        {
           
            result = imageManagement.GetImageForTimeOfDay();
        }
        
        [Then(@"it returns the sun\.jpg image")]
        public void ThenItReturnsTheSun_JpgImage()
        {
            Assert.AreEqual(sunImage, result);
        }
    }
}
