using System;
using TechTalk.SpecFlow;
using TriangleDetector;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TrianguloSpecFlow
{
    [Binding]
    public class SpecFlowFeature5Steps
    {
        TriangleValidator triangleValidator;
        string triangle;
        string result;
        int A, B, C;

        [Given(@"the  sides are (.*) (.*) (.*)")]
        public void GivenTheSidesAre(int p0, int p1, int p2)
        {
            A = p0;
            B = p1;
            C = p2;

            triangleValidator = new TriangleValidator();
        }
        
        [When(@"as the triangle side can not be a negative")]
        public void WhenAsTheTriangleSideCanNotBeANegative()
        {
            try
            {
                triangle = triangleValidator.EsTriangulo(A, B, C);
                result = triangle;
            }
            catch (Exception e)
            {
                ScenarioContext.Current.Add("exception", e);
            }
        }
        
        [Then(@"it ist a triangle")]
        public void ThenItIstATriangle()
        {
            Exception e = (Exception)ScenarioContext.Current["exception"];
            Assert.IsNotNull(e);

            Assert.AreEqual("No es triangulo", e.Message);
        }
    }
}
