using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {
    
    static int CompareStringNumbers(string s1, string s2) {
        if(s1.Length == s2.Length) {
            for(int i=0; i<s1.Length; i++) {
                if(s1[i] != s2[i])
                    return s1[i]-s2[i];
            }
            return 0;
        }
        return s1.Length - s2.Length;
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] unsorted = new string[n];
        for(int unsorted_i = 0; unsorted_i < n; unsorted_i++){
           unsorted[unsorted_i] = Console.ReadLine();
        }
        
        Array.Sort(unsorted, CompareStringNumbers);
        
        foreach(var item in unsorted)
            Console.WriteLine(item);
    }
}

