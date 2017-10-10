using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string a = Console.ReadLine();
        string b = Console.ReadLine();
        
        int[] hash = new int[26];
        
        for(int i=0; i<a.Length; i++)
            hash[a[i] - 'a']++;
        
        for(int i=0; i<b.Length; i++)
            hash[b[i] - 'a']--;
        
        int result = 0;
        for(int i=0; i<26; i++)
            result += Math.Abs(hash[i]);
        
        Console.WriteLine(result);
    }
}
