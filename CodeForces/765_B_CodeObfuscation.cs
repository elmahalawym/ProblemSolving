// B. Code obfuscation
// http://codeforces.com/contest/765/problem/B

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
            bool[] variables = new bool[26];
            Array.Clear(variables, 0, 26);

            string s = Console.ReadLine();

            char cur = s[0];

            if (cur != 'a')
            {
                Console.WriteLine("NO");
                return;
            }

            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] == cur + 1)
                {
                    cur = s[i];
                    continue;
                }
                else if (s[i] > cur + 1)
                {
                    Console.WriteLine("NO");
                    return;
                }
            }

            Console.WriteLine("YES");
        }
    }
}