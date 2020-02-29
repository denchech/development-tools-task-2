using DevToolsProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestDevToolsProject
{
    [TestClass]
    public class DivisionTest
    {
        [TestMethod]
        public void TestCalculate_With_Rational_Numbers()
        {
            var operation = new Division();

            var answer = operation.Calculate(1.0, 2.0);

            Assert.AreEqual(.5, answer, 0.0001);
        }
        [TestMethod]
        public void TestCalculate_With_Zero()
        {
            var operation = new Division();

            Assert.ThrowsException<System.DivideByZeroException>(() => operation.Calculate(1.0, 0));
        }
    }
}
