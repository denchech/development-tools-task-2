using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Text;

namespace DevToolsProject
{
    /// <summary>Implements a calculator's functionality.</summary>
    public class Calculator
    {
        /// <summary>The Operation property represents an operation.</summary>
        /// <value>The Operation property gets/sets the current operation.</value>
        public ICalculate Operation { get; private set; }
        /// <summary>  The Answer property represents an answer.</summary>
        /// <value>The Answer property gets/sets the current value of answer.</value>
        public double Answer { get; set; }
        /// <summary>Initializes a new instance of the <see cref="Calculator"/> class.</summary>
        public Calculator()
        {
            Answer = 0.0;
        }
        /// <summary>Initializes a new instance of the <see cref="Calculator"/> class.</summary>
        /// <param name="symbol">The symbol of the first operation.</param>
        public Calculator(OperationsEnum operation)
        {
            ChangeOperation(operation);
        }
        /// <summary>Changes the operation.</summary>
        /// <param name="symbol">The symbol of operation for changing.</param>
        public void ChangeOperation(OperationsEnum operation)
        {
            Operation = Operations.GetOperation(operation);
        }

        /// <summary>Deletes the answer and resets it to zero.</summary>
        public void DeleteAnswer()
        {
            Answer = 0.0;
        }
        /// <summary>Calculates the specified number.</summary>
        /// <param name="number">The number for calculating.</param>
        /// <returns>Returns the result of currnet operation between current answer and the number.</returns>
        public double Calculate(double number)
        {
            if (Operation != null)
            {
                Answer = Operation.Calculate(Answer, number);
            }
            return Answer;
        }

        public void SaveAnswer()
        {            
            string file = ConfigurationManager.AppSettings.Get("SaveFile");
            var jsonEncode = JsonConvert.SerializeObject(new Answer(Answer), Formatting.Indented);
            File.AppendAllText(file, jsonEncode);
        }
    }
}
