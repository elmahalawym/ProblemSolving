// https://www.hackerrank.com/challenges/grid-challenge

using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        int t = int.Parse(Console.ReadLine());
        while(t-- > 0) {
            int n = int.Parse(Console.ReadLine());
            char[][] grid = new char[n][];
            for(int row=0; row<n; row++) {
                string s = Console.ReadLine();
                grid[row] = new char[n];
                for(int col=0; col<n; col++) {
                    grid[row][col] = s[col];
                }
            }
            
            for(int row=0; row<n; row++) {
                Array.Sort(grid[row]);
            }
            
            Console.WriteLine(AreColumnsSorted(grid, n));
        }
    }
    
    
    static string AreColumnsSorted(char[][] grid, int n) {
        for(int row=1; row<n; row++) {
            for(int col=0; col<n; col++) {
                if(grid[row][col] < grid[row-1][col])
                    return "NO";
            }
        }
        return "YES";
    }
    
    
}