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
        [DataRow(OperationsEnum.Addition, typeof(Addition))]
        [DataRow(OperationsEnum.Substraction, typeof(Substraction))]
        [DataRow(OperationsEnum.Multiplication, typeof(Multiplication))]
        [DataRow(OperationsEnum.Division, typeof(Division))]
        [DataRow(OperationsEnum.Root, typeof(Root))]
        [DataRow(OperationsEnum.Pow, typeof(Pow))]
        public void TestChangeOperation(OperationsEnum input, Type expected)
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
        [DataRow(OperationsEnum.Addition, 1.2)]
        [DataRow(OperationsEnum.Substraction, -1.2)]
        [DataRow(OperationsEnum.Multiplication, 0.0)]
        [DataRow(OperationsEnum.Division, 0.0)]
        [DataRow(OperationsEnum.Root, 0.0)]
        [DataRow(OperationsEnum.Pow, 0.0)]
        public void TestCalculate(OperationsEnum input, double expected)
        {
            var calc = new Calculator(input);
            

            calc.Calculate(1.2);

            Assert.AreEqual(expected, calc.Answer, 0.001);
        }
    }
}

