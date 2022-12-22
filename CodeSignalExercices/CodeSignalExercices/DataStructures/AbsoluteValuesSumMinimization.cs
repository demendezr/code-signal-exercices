using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSignalExercices.DataStructures
{
    internal class AbsoluteValuesSumMinimization
    {
        static int solution(int[] a)
        {
            int result = 0;
            int temp = 0;
            for (int i = 0; i < a.Length; i++)
            {
                int abs = 0;
                for (int j = 0; j < a.Length; j++)
                {
                    int number = a[j] - a[i];
                    if (number < 0) number = number * -1;
                    abs += number;
                }
                if (temp == 0 || temp > abs)
                {
                    result = a[i];
                    temp = abs;
                }
            }

            return result;
        }

        public static void Execute()
        {
            int[] a = new int[] { 2, 4, 7 };

            Console.WriteLine(solution(a));

        }
    }
}
