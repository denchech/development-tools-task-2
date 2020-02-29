using DevToolsProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;
//using NUnit.Framework;
using System;
using Xunit;

namespace UnitTestDevToolsProject
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        [DataRow('+', typeof(Addition))]
        [DataRow('-', typeof(Substraction))]
        [DataRow('*', typeof(Multiplication))]
        [DataRow('/', typeof(Division))]
        public void TestChangeOperation(char input, Type expected)
        {
            var calc = new Calculator();
            
            calc.ChangeOperation(input);

            Assert.AreEqual(calc.Operation.GetType().ToString(), expected.ToString());
        }

        [TestMethod]
        public void TestDeleteAnswer()
        {
            var calc = new Calculator();

            calc.DeleteAnswer();

            Assert.AreEqual(0.0, calc.Answer, 0.001);
        }

        [TestMethod]
        [DataRow('+', 1.2)]
        [DataRow('-', -1.2)]
        [DataRow('*', 0.0)]
        [DataRow('/', 0.0)]
        public void TestCalculate(char input, double expected)
        {
            var calc = new Calculator(input);
            

            calc.Calculate(1.2);

            Assert.AreEqual(expected, calc.Answer, 0.001);
        }
    }
}

