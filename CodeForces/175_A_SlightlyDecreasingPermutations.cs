// http://codeforces.com/problemset/problem/285/A
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
            int n, k;
            var inputs = Console.ReadLine().Split();
            n = int.Parse(inputs[0]);
            k = int.Parse(inputs[1]);

            for (int i = k + 1; i > 0; i--)
                Console.Write(i + " ");
            for (int i = 0; i < n - k - 1; i++)
                Console.Write((k+2+i) + " ");
            Console.Write(Environment.NewLine);
        }

    }
}
