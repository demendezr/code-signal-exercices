using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSignalExercices.DataStructures
{
    internal class ArrayReplace
    {
        static int[] solution(int[] inputArray, int elemToReplace, int substitutionElem)
        {
            for(int i =0; i < inputArray.Length; i++)
            {
                if (inputArray[i] == elemToReplace)
                {
                    inputArray[i] = substitutionElem;
                }
            }
            return inputArray;
        }

        public static void Execute()
        {
            int[] inputArray = new int[] { 1, 2, 3, 4, 5 };
            int elemToReplace = 3;
            int substitutionElem = 0;

            int[] result = solution(inputArray, elemToReplace, substitutionElem);

            Console.WriteLine($"[{string.Join(", ", result)}]");
        }
    }
}
