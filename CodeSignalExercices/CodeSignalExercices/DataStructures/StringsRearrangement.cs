using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSignalExercices.DataStructures
{
    internal class StringsRearrangement
    {
        static List<List<string>> DoPermute(string[] array, int start, int end, List<List<string>> list)
        {
            if (start == end)
            {
                list.Add(new List<string>(array));
            }
            else
            {
                for (var i = start; i <= end; i++)
                {
                    Swap(ref array[start], ref array[i]);
                    DoPermute(array, start + 1, end, list);
                    Swap(ref array[start], ref array[i]);
                }
            }

            return list;
        }

        static void Swap(ref string a, ref string b)
        {
            var temp = a;
            a = b;
            b = temp;
        }

        static bool solution(string[] inputArray)
        {
            List<List<string>> result = new List<List<string>>();
            bool isPossible = true;

            result = DoPermute(inputArray, 0, inputArray.Length - 1, result);

            foreach (List<string> s in result)
            {
                for (int i = 0; i < s.Count - 1; i++)
                {
                    int tempCounter = 0;
                    for (int j = 0; j < s[i].Length; j++)
                    {
                        if (s[i].Substring(j, 1) != s[i + 1].Substring(j, 1))
                        {
                            tempCounter++;
                        }
                    }
                    if (tempCounter > 1 || tempCounter == 0)
                    {
                        isPossible = false;
                        break;
                    }
                    else isPossible = true;
                }

                if (isPossible) break;
            }

            return isPossible;
        }

        public static void Execute()
        {
            string[] inputArray = new string[] { 
                 "abc",
                 "bef",
                 "bcc",
                 "bec",
                 "bbc",
                 "bdc" 
            };
            Console.WriteLine(solution(inputArray));
        }
    }
}
