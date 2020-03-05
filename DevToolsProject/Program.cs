using System;
using System.Configuration;
using System.IO;
using System.Text;

namespace DevToolsProject
{
    class Program
    {        
        static void Main(string[] args)
        {
            Calculator x = new Calculator();
            //x.SaveAnswer();
            StreamWriter sw = new StreamWriter("TextFile1.txt");
            sw.Write("something");
            sw.Close();
            Console.WriteLine("Hello World");
        }
    }
}
