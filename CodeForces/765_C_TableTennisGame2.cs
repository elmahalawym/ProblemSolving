// C. Table Tennis Game 2
// http://codeforces.com/problemset/problem/765/C

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    class Program
    {
        static void Main()
        {
            long k, a, b;
            var inputs = Console.ReadLine().Split(' ');
            k = Int64.Parse(inputs[0]);
            a = Int64.Parse(inputs[1]);
            b = Int64.Parse(inputs[2]);

            Console.WriteLine(GetMaximumNumberOfGames(k, a, b));
        }

        private static long GetMaximumNumberOfGames(long k, long a, long b)
        {
            if ((a < k && b < k) ||
                (a < k && b % k != 0) ||
                (b < k && a%k != 0))
                return -1;

            return a / k + b / k;
        }
    }
}