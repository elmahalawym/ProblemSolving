// http://codeforces.com/problemset/problem/92/A
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    class Program
    {
        static int[] arr = new int[51];

        static void Main()
        {
            string[] line = Console.ReadLine().Split();
            int n = int.Parse(line[0]);
            int m = int.Parse(line[1]);

            for (int i = 0; i < arr.Length; i++) arr[i] = -1;

            m %= Sum(n);
            for (int i = 1; i < n; i++)
            {
                if (m < i)
                {
                    Console.WriteLine(m);
                    return;
                }
                m -= i;
            }
            Console.WriteLine(m);
        }

        static int Sum(int x)
        {
            if (arr[x] != -1)
                return arr[x];
            if (x <= 0)
                return x;

            return (arr[x] = x + Sum(x - 1));
        }

    }
}
