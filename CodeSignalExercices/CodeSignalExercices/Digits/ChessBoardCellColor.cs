using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSignalExercices.Digits
{
    internal class ChessBoardCellColor
    {
        static bool solution(string cell1, string cell2)
        {
            Dictionary<string, int> chess = new Dictionary<string, int>();
            string[] letters = new string[] {"a", "b", "c", "d", "e", "f", "g", "h" };

            for(int i=1;i<9;i++) 
            {
                int counter = 0;
                for (int j=0; j<letters.Length; j++)
                {
                    int value = 0;
                    if (i%2 != 0) // uneven
                    {
                        if (counter % 2 == 0) value = 1;
                    }
                    else
                    {
                        if (counter % 2 != 0) value = 1;
                    }

                    chess.Add($"{letters[j]}{i}",value);
                    counter++;
                }
            }

            if(chess.ContainsKey(cell1.ToLower()) && chess.ContainsKey(cell2.ToLower()))
            {
                return chess[cell1.ToLower()] == chess[cell2.ToLower()];
            }
            return false;
        }

        public static void Execute()
        {
            string cell1 = "A1";
            string cell2 = "H3";

            Console.WriteLine(solution(cell1, cell2));
        }
    }
}
