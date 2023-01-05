using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSignalExercices.DataStructures
{
    internal class ExtractEachKth
    {
        static int[] solution(int[] inputArray, int k)
        {
            List<int> resultArray = new List<int>();
            int counter = 1;

            for (int i = 0; i < inputArray.Length; i++)
            {
                if (counter < k)
                {
                    resultArray.Add(inputArray[i]);
                    counter++;
                }
                else counter = 1;
            }

            return resultArray.ToArray();
        }

        public static void Execute()
        {
            int[] inputArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int k = 3;
            Console.WriteLine($"[{string.Join(",", solution(inputArray, k))}]");
        }
    }
}
