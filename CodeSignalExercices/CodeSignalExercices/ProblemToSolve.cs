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
            
            for(int i = 0; i < input.Length; i++)
            {
                for (int k = 0; k < input.Length-1; k++)
                {
                    string item1 = input[k].ToString();
                    int weight1 = 0;
                    for (int j = 0; j < item1.Length; j++)
                    {
                        weight1 += Convert.ToInt32(item1.Substring(j, 1));
                    }

                    int weight2 = 0;
                    string item2 = input[k+1].ToString();
                    for (int j = 0; j < item2.Length; j++)
                    {
                        weight2 += Convert.ToInt32(item2.Substring(j, 1));
                    }

                    if (weight1 > weight2)
                    {
                        int temp = input[k];
                        input[k] = input[k+1];
                        input[k+1] = temp;
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
