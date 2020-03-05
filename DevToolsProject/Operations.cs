using System;
using System.Collections.Generic;
using System.Text;

namespace DevToolsProject
{
    public enum OperationsEnum
    {

        Addition,
        Substraction,
        Division,
        Multiplication,
        Root,
        Pow,
        Log,
        // Add enum of new operations here
    }

    public static class Operations
    {
        private static Dictionary<OperationsEnum, ICalculate> _operations;

        static Operations()
        {
            _operations = new Dictionary<OperationsEnum, ICalculate>()
            {
                { OperationsEnum.Addition, new Addition() },
                { OperationsEnum.Substraction, new Substraction() },
                { OperationsEnum.Division, new Division() },
                { OperationsEnum.Multiplication, new Multiplication() },
                { OperationsEnum.Root, new Root() },
                { OperationsEnum.Pow, new Pow() },
                { OperationsEnum.Log, new Log() },
                // Add new operations here
            };
        }

        public static ICalculate GetOperation(OperationsEnum operationsEnum)
        {
            ICalculate operation;
            if (!_operations.TryGetValue(operationsEnum, out operation))
            {
                throw new ArgumentException("Operation doesn't exist");
            }
            else
            {
                return operation;
            }
        }
    }
}
