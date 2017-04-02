// A. Neverending competitions
// http://codeforces.com/contest/765/problem/0

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
            int n = int.Parse(Console.ReadLine());
            string home = Console.ReadLine();

            List<Tuple<string, string>> flights = new List<Tuple<string, string>>();

            while (n-- > 0)
            {
                var input = Console.ReadLine().Split(new string[] { "->" }, StringSplitOptions.RemoveEmptyEntries);
                flights.Add(new Tuple<string, string>(input[0], input[1]));
            }

            string current = home;
            while(flights.Count > 0)
            {
                var flight = flights.Where(f => f.Item1 == current).FirstOrDefault();

                if(flight == null)
                {
                    Console.WriteLine("contest");
                    return;
                }
                
                flights.Remove(flight);
                current = flight.Item2;
            }

            Console.WriteLine(current == home ? "home" : "contest");
        }
    }
}