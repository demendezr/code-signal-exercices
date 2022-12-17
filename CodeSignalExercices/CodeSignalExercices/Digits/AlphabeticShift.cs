using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSignalExercices.Digits
{
    internal class AlphabeticShift
    {
        static string solution(string inputString)
        {
            Dictionary<string, string> alphabet = new Dictionary<string, string>
            {
                { "a", "b" }, { "b", "c" }, { "c", "d" }, { "d", "e" }, { "e", "f" },
                { "f", "g" }, { "g", "h" }, { "h", "i" }, { "i", "j" }, { "j", "k" },
                { "k", "l" }, { "l", "m" }, { "m", "n" }, { "n", "o" }, { "o", "p" },
                { "p", "q" }, { "q", "r" }, { "r", "s" }, { "s", "t" }, { "t", "u" },
                { "u", "v" }, { "v", "w" }, { "w", "x" }, { "x", "y" }, { "y", "z" },
                { "z", "a" }
            };

            string result = "";
            for(int i=0;i<inputString.Length;i++) {
                string letter = inputString.Substring(i, 1);
                if (alphabet.ContainsKey(letter))
                {
                    result += alphabet[letter];
                }
            }
            return result;
        }

        public static void Execute()
        {
            string inputString = "crazy"; //dsbaz
            Console.WriteLine(solution(inputString));
        }
    }
}
