using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSignalExercices.Digits
{
    internal class FirstDigit
    {
        static char solution(string inputString)
        {
            char result = '0';
            for (int i = 0; i < inputString.Length; i++)
            {
                string letter = inputString.Substring(i, 1);
                try
                {
                    int number = Convert.ToInt32(letter);
                    result = Convert.ToChar(letter);
                    break;
                }
                catch
                {
                    continue;
                }
            }

            return result;
        }

        public static void Execute()
        {
            string inputString = "var_1__Int";
            Console.WriteLine(solution(inputString));
        }
    }
}
