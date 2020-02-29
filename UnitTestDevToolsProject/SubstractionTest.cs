using DevToolsProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestDevToolsProject
{
    [TestClass]
    public class SubstractionTest
    {
        [TestMethod]
        public void TestCalculate()
        {
            var operation = new Substraction();

            var answer = operation.Calculate(1.0, 2.0);

            Assert.AreEqual(-1.0, answer, 0.0001);
        }
    }
}
