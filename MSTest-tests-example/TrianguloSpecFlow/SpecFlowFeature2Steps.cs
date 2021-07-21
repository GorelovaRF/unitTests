using System;
using TechTalk.SpecFlow;
using TriangleDetector;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TrianguloSpecFlow
{
    [Binding]
    public class SpecFlowFeature2Steps
    {
        TriangleValidator triangleValidator;
        string triangleScalene;
        string result;
        int A, B, C;

        [Given(@"the triangle sides are (.*) (.*) (.*)")]
        public void GivenTheTriangleSidesAre(int p0, int p1, int p2)
        {
            A = p0;
            B = p1;
            C = p2;
            triangleValidator = new TriangleValidator();
            triangleScalene = triangleValidator.EsTriangulo(A, B, C);
            
          
        }
        
        [When(@"as all sides are different")]
        public void WhenAsAllSidesAreDifferent()
        {
            result = triangleScalene;
        }
        
        [Then(@"the result is triangle scalene")]
        public void ThenTheResultIsTriangleScalene()
        {
            Assert.AreEqual(TriangleDetector.TriangleValidator.ESCALENO, result);
        }
    }
}
