using System;
using TechTalk.SpecFlow;
using TriangleDetector;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TrianguloSpecFlow
{
    [Binding]
    public class SpecFlowFeature1Steps
    {

        TriangleValidator triangleValidator;
        string triangle;
        string result;
        int A, B, C;

        [Given(@"the sides are (.*) (.*) (.*)")]
        public void GivenTheSidesAre(int p0, int p1, int p2)
        {
            A = p0;
            B = p1;
            C = p2;

            triangleValidator = new TriangleValidator();
            triangle = triangleValidator.EsTriangulo(A,B,C);

            
        }
        
        [When(@"because all side are equal")]
        public void WhenBecauseAllSideAreEqual()
        {
            result = triangle;
            
           
        }
        
        [Then(@"the resuly is triangle equilateral")]
        public void ThenTheResulyIsTriangleEquilateral()
        {
            Assert.AreEqual(TriangleDetector.TriangleValidator.EQUILATERO, result);
        }
    }
}
