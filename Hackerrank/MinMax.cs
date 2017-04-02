// https://www.hackerrank.com/challenges/angry-children

using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        
        int n = int.Parse(Console.ReadLine());
        long k = Int64.Parse(Console.ReadLine());
        long[] arr = new long[n];
        for(int i=0; i<n; i++) {
            arr[i] = Int64.Parse(Console.ReadLine());
        }
        
        Array.Sort(arr);
        
        for(int i=n-1; i>0; i--) {
            arr[i] = arr[i] - arr[i-1];
        }
        
        long min = Int64.MaxValue;
        
        for(int i=0; i<n-k+1; i++) {
            long sum = 0;
            for(int j=i+1; j<i+k; j++)
                sum += arr[j];
            min = Math.Min(sum, min);
        }
        
        Console.WriteLine(min);
    }
}