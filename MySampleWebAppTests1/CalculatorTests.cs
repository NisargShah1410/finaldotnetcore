using Microsoft.VisualStudio.TestTools.UnitTesting;
using MySampleWebApp;
using System;
using System.Collections.Generic;
using System.Text;

namespace MySampleWebApp.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void AddTest()
        {
            Calculator calc = new Calculator();
            int actualtResult = calc.Add(2, 3);
            Assert.AreEqual(actualtResult, 5);
        }

        [TestMethod()]
        public void SubtractTest()
        {
            Calculator calc = new Calculator();
            int actualtResult = calc.Subtract(3, 6);
            Assert.AreEqual(actualtResult, 3);
        }
    }
}