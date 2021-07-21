using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TriangleDetector;

namespace TrianguloMSTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange 
            TriangleValidator triangleValidator;
            string triangle;
            string result;
            int A, B, C;

            A = 10;
            B = 10;
            C = 10;

            triangleValidator = new TriangleValidator();
            triangle = triangleValidator.EsTriangulo(A, B, C);

            //Act 

            result = triangle;

            //Assert
            Assert.AreEqual(TriangleDetector.TriangleValidator.EQUILATERO, result);

        }
    }
}
