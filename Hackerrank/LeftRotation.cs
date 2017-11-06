using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int[] leftRotation(int[] a, int d) {
        d %= a.Length;
        
        var result = new int[a.Length];

        int idx = 0;
        
        for(int i=d; i<a.Length; i++) 
            result[idx++] = a[i];
        for(int i=0; i<d; i++)
            result[idx++] = a[i];
        
        return result;
    }

    static void Main(String[] args) {
        string[] tokens_n = Console.ReadLine().Split(' ');
        //int n = Convert.ToInt32(tokens_n[0]);
        int d = Convert.ToInt32(tokens_n[1]);
        string[] a_temp = Console.ReadLine().Split(' ');
        int[] a = Array.ConvertAll(a_temp,Int32.Parse);
        int[] result = leftRotation(a, d);
        Console.WriteLine(String.Join(" ", result));
    }
}

