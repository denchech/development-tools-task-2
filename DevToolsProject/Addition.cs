using System;
using System.Collections.Generic;
using System.Text;

namespace DevToolsProject
{
    /// <summary>This class implements addition.</summary>
    /// <seealso cref="DevToolsProject.ICalculate" />
    public class Addition : ICalculate
    {
        /// <summary>Calculates the addition.</summary>
        /// <param name="first">The first term.</param>
        /// <param name="second">The second term.</param>
        /// <returns>Returns the result of addition of two numbers.</returns>
        public double Calculate(double first, double second)
        {
            return first + second;
        }
    }
}
