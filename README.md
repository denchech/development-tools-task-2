# development-tools-task-2

A simple calculator, written for understanding basic git functions

## Install

You have to install 
- [System.Configuration.ConfigurationManager](https://github.com/dotnet/corefx)
- [Newtonsoft.Json](https://www.newtonsoft.com/json)

from NuGet manager

## Usage

``` csharp
Calculator calculator = new Calculator(OperationsEnum.Addition);
calculator.Calculate(2); // return 2.0
calculator.ChangeOperation(OperationsEnum.Pow);
calculator.Calculate(3); // return 8.0
```

## Support

You can add new operations to calculator.
You have to add new implementation of ICalculate, add new value of enum OperationsEnum and pair (key, value) to class Operations

