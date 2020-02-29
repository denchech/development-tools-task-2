using Microsoft.VisualStudio.TestTools.UnitTesting;
using DevToolsProject;

namespace UnitTestDevToolsProject
{
    [TestClass]
    public class AdditionTest
    {
        [TestMethod]
        public void TestCalculate()
        {
            Addition operation = new Addition();

            var answer = operation.Calculate(1.0, 2.0);

            Assert.AreEqual(3.0, answer, 0.0001);
        }

    }
}
