using System;
using System.Collections.Generic;
using System.Text;

namespace DevToolsProject
{
    /// <summary>Implements an operation.</summary>
    public interface ICalculate
    {
        /// <summary>Calculates an operation.</summary>
        /// <param name="first">The first number.</param>
        /// <param name="second">The second number.</param>
        /// <returns>Returns a result of operation.</returns>
        public double Calculate(double first, double second);
    }
}
