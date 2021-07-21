using System;
using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSTest_tests_example.Private;


namespace EjercicioSpecFlow
{

    [Binding]
    public class LogonInfoSteps
    {
        LogonInfo logonInfo = null;

        string userId = "";
        string password = "";
        string passResult;


        [Given(@"the user name is  ""(.*)""")]
        public void GivenTheUserNameIs(string p0)
        {
            userId = p0;
            
        }
        
        [Given(@"the password is ""(.*)""")]
        public void GivenThePasswordIs(string p0)
        {
            password = p0;
        }
        
        [When(@"the password is validated")]
        public void WhenThePasswordIsValidated()
        {
            logonInfo = new LogonInfo(userId, password);
            passResult = logonInfo.Password;
             
            
        }
        
        [Then(@"it returns true")]
        public void ThenItReturnsTrue()
        {
            Assert.AreEqual(password, passResult);
        }
    }
}
