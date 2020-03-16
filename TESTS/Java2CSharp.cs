using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BrainCompiler.TESTS
{
    public class Java2CSharp
    {
        //private string code;
        private static StringBuilder compile = new StringBuilder();
        private static int indent;

        public Java2CSharp(string code)
        {
            //code = feedInJava(@"convert\test.java");
            //convert(code, compile);
            TokParser.Anaylize(JavaToken.SystemOut, code);
            Console.WriteLine(compile.ToString());
        }
        public string convert(string code, StringBuilder source)
        {
            //poor parsing, make more advanced with naming conventions
            //System.out.println("Hello, World"); 
            // for (int i = 0; i < code.Length; i++)
            //  {
            //   for (int t = 0; t < indent; t++) source.Append("\t");
            //change to switch code equals token loop
          //  if (code.Contains("System.out.println"))
            //    source.Append("Console.WriteLine\n");

            //Console.WriteLine(code.ToString());
            return source.ToString() ;
            //  if (i + 1 < code.Length) indent--;
            //  }
        }

        //reads java file
        public string feedInJava(string path)
        {
            string readText = File.ReadAllText(path);
            foreach (char s in readText)
            {
                Console.WriteLine(s);

            }
            return readText.ToString();
        }
    }
}
