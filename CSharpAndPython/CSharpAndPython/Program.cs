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
            

            
            try
            {
                using Process myProcess = new Process();
                myProcess.StartInfo.UseShellExecute = false;
                myProcess.StartInfo.
                myProcess.StartInfo.FileName = @"C:\Users\Landon\Documents\GitHub\Stock-Modeling\CSharpAndPython\PythonBackend\PythonBackend.py";
                myProcess.Start();
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.Message);
            }

            Console.WriteLine("This is C# Again!");           
        }
    }
}
