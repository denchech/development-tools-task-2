using System;
using System.Collections.Generic;
using System.Text;

namespace DevToolsProject
{
    /// <summary>This class impements the division.</summary>
    /// <seealso cref="DevToolsProject.ICalculate" />
    public class Division : ICalculate
    {
        /// <summary>Calculates the division.</summary>
        /// <param name="first">The dividend.</param>
        /// <param name="second">The divider.</param>
        /// <returns>Returns the quotient produced by division of two numbers.</returns>
        /// <exception cref="DivideByZeroException">Division by zero</exception>
        public double Calculate(double first, double second)
        {
            if (second == 0.0)
            {
                throw new DivideByZeroException("Division by zero");
            }
            return first / second;
        }
    }
}
