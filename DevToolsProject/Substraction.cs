using System;
using System.Collections.Generic;
using System.Text;

namespace DevToolsProject
{
    /// <summary>Calculates the substraction.</summary>
    /// <seealso cref="DevToolsProject.ICalculate" />
    public class Substraction : ICalculate
    {
        /// <summary>Calculates the division.</summary>
        /// <param name="first">The minuend.</param>
        /// <param name="second">The subtrahend.</param>
        /// <returns>Returns the diffrence between two numbers.</returns>
        public double Calculate(double first, double second)
        {
            return first - second;
        }
    }
}
