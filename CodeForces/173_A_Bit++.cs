// http://codeforces.com/problemset/problem/282/A
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    class Program
    {
        static void Main(string[] args)
        {
            int res = 0;
            int n = int.Parse(Console.ReadLine());

            while (n-- > 0)
            {
                if (Console.ReadLine().Contains("++"))
                    res++;
                else
                    res--;
            }

            Console.WriteLine(res);
        }
    }
}
