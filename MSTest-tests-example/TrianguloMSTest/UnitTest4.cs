using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TriangleDetector;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TrianguloMSTest
{
    [TestClass]
    public class UnitTest4
    {
        [TestMethod]
        public void TestMethod4()
        {
            //Arrange 
            TriangleValidator triangleValidator;
            string triangle;
            string result;
            int A, B, C;

            A = 10;
            B = 2;
            C = 1;

            triangleValidator = new TriangleValidator();
            try
            {
                triangle = triangleValidator.EsTriangulo(A, B, C);
                result = triangle;
            }
            catch (Exception e)
            {
                Assert.AreEqual("No es triangulo", e.Message);
            }





        }
    }
}
