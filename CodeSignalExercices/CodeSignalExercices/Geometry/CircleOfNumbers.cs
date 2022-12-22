using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSignalExercices.Geometry
{
    internal class CircleOfNumbers
    {
        static int solution(int n, int firstNumber)
        {
            int middle = n / 2;
            int[] firstArray = new int[middle];
            int[] secondArray = new int[middle];

            for(int i = 0; i < middle; i++)
            {
                firstArray[i] = i;
                secondArray[i] = middle + i;
            }

            if (firstNumber >= middle) return firstArray[firstNumber-middle];

            return secondArray[firstNumber];
        }

        public static void Execute()
        {
            int n = 18;
            int firstNumber = 6; 

            Console.WriteLine(solution(n, firstNumber));
        }
    }
}
