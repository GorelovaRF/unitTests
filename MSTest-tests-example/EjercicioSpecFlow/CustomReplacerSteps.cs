using System;
using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSTest_tests_example.Basics;


namespace EjercicioSpecFlow
{
    [Binding]
    public class CustomReplacerSteps
    {
        CustomReplacer customReplacer = null;
        string str = "";
        string charStr = "";
        string result = "";
        

        [Given(@"the char string ""(.*)""")]
        public void GivenTheCharString(string p0)
        {
            customReplacer = new CustomReplacer();
            str = p0;
        }
        
        
        [Given(@"the letter that will be replaced is ""(.*)""")]
        public void GivenTheLetterThatWillBeReplacedIs(string p0)
        {
            charStr = p0;
        }
        
        [When(@"the letter o will be replaced in every word")]
        public void WhenTheLetterOWillBeReplacedInEveryWord()
        {
            result = customReplacer.CustomReplace(str, charStr);
        }
        
        [Then(@"it returns ""(.*)""")]
        public void ThenItReturns(string p0)
        {
            Assert.AreEqual(p0, result);
        }
    }
}
