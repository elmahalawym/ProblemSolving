// http://codeforces.com/problemset/problem/34/B
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
            int m = int.Parse(Console.ReadLine().Split()[1]);
            Console.WriteLine(Console.ReadLine().Split().Select(s => int.Parse(s)).OrderBy(i => i).Take(m).Where(i => i < 0).Sum() * -1);
        }
    }
}
