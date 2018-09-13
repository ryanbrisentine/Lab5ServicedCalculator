using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestCalculations
{
    [TestClass]
    public class UnitTest1
    {
        private Calculator.CalculatorSoapClient calcRef;
        [TestMethod]
        public void TestAdd()
        {
            calcRef = new Calculator.CalculatorSoapClient();
            double d = calcRef.Add(2.0, 2.0);
            Assert.AreEqual(d, 4.0);
        }

        [TestMethod]
        public void TestForAll()
        {
            calcRef = new Calculator.CalculatorSoapClient();
            double e = calcRef.Subtrct(3.0, 2.0);
            double f = calcRef.Multiply(3.0, 5.0);
            double g = calcRef.Divide(6.0, 2.0);
            Assert.AreEqual(e, 1.0);
            Assert.AreEqual(f, 15.0);
            Assert.AreEqual(g, 3.0);
        }

        [TestMethod]
        public void TestSqrt()
        {
            calcRef = new Calculator.CalculatorSoapClient();
            double h = calcRef.SquareRoot(9.0);
            Assert.AreEqual(h, 3.0);
        }

        [TestMethod]
        public void TestHalve()
        {
            calcRef = new Calculator.CalculatorSoapClient();
            double i = calcRef.Halve(4.0);
            Assert.AreEqual(i, 2.0);
        }

        [TestMethod]
        public void TestQuarter()
        {
            calcRef = new Calculator.CalculatorSoapClient();
            double j = calcRef.Quarter(8.0);
            Assert.AreEqual(j, 2.0);
        }
    }
}
