using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using DevToolsProject;

namespace UnitTestDevToolsProject
{
    [TestClass]
    public class RootTest
    {
        [TestMethod]
        public void TestCalculate()
        {
            Root operation = new Root();

            var answer = operation.Calculate(8.0, 3.0);

            Assert.AreEqual(2.0, answer, 1e-9);
        }
    }
}
