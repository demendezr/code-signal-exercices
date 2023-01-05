using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSignalExercices.Digits
{
    internal class DifferentSymbolsNaive
    {
        static int solution(string s)
        {
            List<string> listStringToCompare = new List<string>();

            for (int i = 0; i < s.Length; i++)
            {
                string character = s.Substring(i, 1);
                if (!listStringToCompare.Contains(character))
                {
                    listStringToCompare.Add(character);
                }
            }

            return listStringToCompare.Count;
        }

        public static void Execute()
        {
            string s = "cabca";
            Console.WriteLine(solution(s));
        }
    }
}
