using System;
using BrainCompiler.TESTS;
namespace BrainCompiler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Loading compiler");
            Java2CSharp t = new Java2CSharp("System.out.println(\"Test\");");
        }
    }
}
