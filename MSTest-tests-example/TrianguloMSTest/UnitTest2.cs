using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TriangleDetector;

namespace TrianguloMSTest
{
     [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod2()
        {
            //Arrange 
            TriangleValidator triangleValidator;
            string triangle;
            string result;
            int A, B, C;

            A = 10;
            B = 9;
            C = 8;

            triangleValidator = new TriangleValidator();
            triangle = triangleValidator.EsTriangulo(A, B, C);

            //Act 

            result = triangle;

            //Assert
            Assert.AreEqual(TriangleDetector.TriangleValidator.ESCALENO, result);

        }
    }
}
