using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSignalExercices.DataStructures
{
    internal class ArrayMaxConsecutiveSum
    {
        static int solution(int[] inputArray, int k)
        {            
            int max = inputArray.Take(k).Sum();
            int sum = max;

            for (int i = 1; i <= inputArray.Length - k; i++)
            {
                sum = sum - inputArray[i - 1] + inputArray[i + k - 1];

                if (sum > max)
                    max = sum;
            }
            return max;
        }

        public static void Execute()
        {
            int[] inputArray = new int[] { 2, 3, 5, 1, 6 };
            int k = 2;
            Console.WriteLine(solution(inputArray, k));
        }
    }
}
