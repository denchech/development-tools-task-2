using System;
using DevToolsProject;

namespace DevToolsProject
{
    public class Root : ICalculate
    {
        public double Calculate(double first, double second)
        {
            if (second == 0)
            {
                throw new DivideByZeroException("Root can't be in degree 0");
            }
            return Math.Pow(first, 1.0 / second);

        }
    }
}
