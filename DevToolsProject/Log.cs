using System;
using System.Collections.Generic;
using System.Text;

namespace DevToolsProject
{
    public class Log : ICalculate
    {
        public double Calculate(double first, double second)
        {
            return Math.Log(second, first);
        }
    }
}
