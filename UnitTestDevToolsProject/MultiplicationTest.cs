using DevToolsProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestDevToolsProject
{
    [TestClass]
    public class MultiplicationTest
    {
        [TestMethod]
        public void TestCalculate()
        {
            var operation = new Multiplication();

            var answer = operation.Calculate(1.0, 2.0);

            Assert.AreEqual(2.0, answer, 0.0001);
        }
    }
}
