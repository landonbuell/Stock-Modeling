using System;
using System.Diagnostics;
using IronPython.Hosting;

namespace CSharpAndPython
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("This is C# Speaking!");
            Console.WriteLine("Waiting on Python...");

            string pyScriptPath = @"C:\Users\Landon\Documents\GitHub\Stock-Modeling\CSharpAndPython\PythonBackend\PythonBackend.py";

            var PythonEngine = Python.CreateEngine();
            var Scope = PythonEngine.CreateScope();
            var Source = PythonEngine.CreateScriptSourceFromFile(pyScriptPath);

            Console.WriteLine("This is C# Again!");           
        }
    }
}
