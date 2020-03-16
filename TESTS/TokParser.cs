using System;
using System.Collections.Generic;
using System.Text;

namespace BrainCompiler.TESTS
{
    public class TokParser
    {
        //gets (sets)
        public static StringBuilder builder = new StringBuilder();
        public static void Anaylize(JavaToken inputTok, string code)
        {
            string[] tmp;
            switch (inputTok)
            {
                case JavaToken.SystemOut:
                    if (code.Contains("System.out.println")) //tok
                    {
                        tmp = code.Split('.', '(', ')');
                        foreach (string tok in tmp)
                        {
                            Console.WriteLine(tok);
                        }
                    }
                    break;

                default:
                    break;
            }
        }
    }
}
