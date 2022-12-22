using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSignalExercices
{
    internal class ProblemToSolve
    {
        public static int[] SolveProblem(int[] input)
        {
            /*
             *  Input = [123, 89, 12, 67, 43] // input array
                Weights = [6, 17, 3, 13, 7] // weights of each element of the input array
                Output = [12, 123, 43, 67, 89] // output array
             */
            
            for(int i=0;i<input.Length;i++)
            {
                for(int j = 0; j < input.Length - 1; j++)
                {
                    string strNumber1 = input[j].ToString();
                    int weightNumber1 = 0;
                    string strNumber2 = input[j+1].ToString();
                    int weightNumber2 = 0;

                    for(int k = 0; k < strNumber1.Length; k++)
                    {
                        weightNumber1+= Convert.ToInt32(strNumber1.Substring(k,1));
                    }

                    for (int k = 0; k < strNumber2.Length; k++)
                    {
                        weightNumber2 += Convert.ToInt32(strNumber2.Substring(k, 1));
                    }

                    if (weightNumber1 > weightNumber2)
                    {
                        int temp = input[j];
                        input[j] = input[j + 1];
                        input[j + 1] = temp;
                    }
                }
            }

            return input;
        }
        public static void Execute()
        {
            int[] input = new int[] { 123, 89, 12, 67, 43 };
            int[] output = SolveProblem(input);

            Console.WriteLine(string.Join(",", output));
        }
    }
}
