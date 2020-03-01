using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Text;
using DevToolsProject;

namespace UnitTestDevToolsProject
{
    [TestClass]
    public class PowTest
    {
        [TestMethod]
        public void TestCalulate()
        {
            Pow operation = new Pow();

            var answer = operation.Calculate(3.0, 2.0);

            Assert.AreEqual(9.0, answer, 1e-9);
        }
    }
}
