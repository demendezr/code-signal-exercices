using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSignalExercices.Operations
{
    internal class DepositProfit
    {
        static int solution(int deposit, int rate, int threshold)
        {
            int counter = 0;
            
            decimal newDeposit = Convert.ToDecimal(deposit);
            while (true)
            {
                if (newDeposit >= threshold) break;
                decimal currentAmount = newDeposit * Decimal.Divide(rate, 100);
                newDeposit += currentAmount;
                counter++;
            }

            return counter;
        }

        public static void Execute()
        {
            int deposit = 1, rate = 100, threshold = 64;

            Console.WriteLine(solution(deposit, rate, threshold));
        }
    }
}
