using System;
using TechTalk.SpecFlow;
using TriangleDetector;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TrianguloSpecFlow
{
    [Binding]
    public class SpecFlowFeature4Steps
    {
        TriangleValidator triangleValidator;
        string triangle;
        string result;
        int A, B, C;

        [Given(@"the selected sides are (.*) (.*) (.*)")]
        public void GivenTheSelectedSidesAre(int p0, int p1, int p2)
        {
            A = p0;
            B = p1;
            C = p2;

            triangleValidator = new TriangleValidator();
           
        }
        
        [When(@"as the sum of two triangle sides must be more than one sides")]
        public void WhenAsTheSumOfTwoTriangleSidesMustBeMoreThanOneSides()
        {
           try 
            {
                triangle = triangleValidator.EsTriangulo(A, B, C);
                result = triangle;
            }
            catch(Exception e)
            {
                ScenarioContext.Current.Add("exception",e);
            }
            }
        
        [Then(@"it is not a triangle")]
        public void ThenItIsNotATriangle()
        {
            Exception e = (Exception)ScenarioContext.Current["exception"];
            Assert.IsNotNull(e);
            
            Assert.AreEqual("No es triangulo",e.Message);
        }
    }
}
