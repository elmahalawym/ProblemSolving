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
            string[] line = Console.ReadLine().Split();
            int r = int.Parse(line[0]);
            int c = int.Parse(line[1]);

            List<int> rows = new List<int>();
            List<int> cols = new List<int>();

            for (int i = 0; i < r; i++)
            {
                string s = Console.ReadLine();
                if (s.Any(ch => ch == 'S'))
                    rows.Add(i);
                for (int j = 0; j < c; j++)
                    if (s[j] == 'S' && !cols.Contains(j))
                        cols.Add(j);
            }
            int nRows = r - rows.Count;
            int nCols = c - cols.Count;

            Console.WriteLine((nRows * c) + (nCols * r) - (nRows * nCols));
        }
    }
}
