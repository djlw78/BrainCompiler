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
                        tmp = Tokenizer(code);
                        foreach (string tok in tmp)
                        {
                            Console.Write(tok + " ");
                        }
                    }
                    break;

                default:
                    break;
            }
        }

        public static string[] Tokenizer(string code)
        {
            //create offical seperators
            return code.Split('.', '(', ')');
        }
    }
}
