using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CodeSignalExercices.Digits
{
    internal class VariableName
    {
        static bool solution(string name)
        {
            Regex rg = new Regex(@"^[0-9]*$"); // only numbers

            if (rg.Match(name.Substring(0, 1)).Success) return false;

            rg = new Regex(@"\w+"); // letters, digits and underscores
            return rg.Match(name).Length == name.Length;
        }

        public static void Execute()
        {
            string name = "2w2";
            Console.WriteLine(solution(name));
        }
    }
}
