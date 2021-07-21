using System;
using TechTalk.SpecFlow;
using TriangleDetector;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TrianguloSpecFlow
{
    [Binding]
    public class SpecFlowFeature3Steps
    {
        TriangleValidator triangleValidator;
        string triangleIsocele;
        string result;
        int A, B, C;

        [Given(@"the sides of triangle are (.*) (.*) (.*)")]
        public void GivenTheSidesOfTriangleAre(int p0, int p1, int p2)
        {
            A = p0;
            B = p1;
            C = p2;

            triangleValidator = new TriangleValidator();
            triangleIsocele = triangleValidator.EsTriangulo(A, B, C);
        }
        
        [When(@"because two of all sides are equal")]
        public void WhenBecauseTwoOfAllSidesAreEqual()
        {
            result = triangleIsocele;
        }
        
        [Then(@"ir returns triangle isocele")]
        public void ThenIrReturnsTriangleIsocele()
        {
            Assert.AreEqual(TriangleDetector.TriangleValidator.ISOSCELES, result);
        }
    }
}
