using System;
using System.Collections.Generic;
using System.Text;

namespace DevToolsProject
{
    public class Pow : ICalculate
    {
        public double Calculate(double first, double second)
        {
            return Math.Pow(first, second);
        }
    }
}
