using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSignalExercices.Digits
{
    internal class EvenDigitsOnly
    {
        static bool solution(int n)
        {
            string digits = n.ToString();

            for(int i=0; i<digits.Length; i++) { 
                int digit = Convert.ToInt32(digits.Substring(i,1));
                if (digit % 2 != 0)
                {
                    return false;
                }
            }

            return true;
        }

        public static void Execute()
        {
            int n = 642386;
            Console.WriteLine(solution(n));
        }
    }
}
