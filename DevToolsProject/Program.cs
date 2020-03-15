using System;
using System.Configuration;
using System.IO;
using System.Text;

namespace DevToolsProject
{
    class Program
    {
        public static void NewMethod()
        {
            Console.WriteLine("New method to test Git Kraken");
        }

        static void Main(string[] args)
        {
            Calculator x = new Calculator();
            StreamWriter sw = new StreamWriter("TextFile1.txt");
            sw.Write("something");
            sw.Close();
            Console.WriteLine("Hello World");
        }
    }
}
