using System;
using System.Collections.Generic;
using System.Text;

namespace DevToolsProject
{
    /// <summary>Calculates the multiplication.</summary>
    /// <seealso cref="DevToolsProject.ICalculate" />
    public class Multiplication : ICalculate
    {
        /// <summary>Calculates an operation.</summary>
        /// <param name="first">The first multiplier.</param>
        /// <param name="second">The second multiplier.</param>
        /// <returns>Returns the result of multiplication of two numbers.</returns>
        public double Calculate(double first, double second)
        {
            return first * second;
        }
    }
}
