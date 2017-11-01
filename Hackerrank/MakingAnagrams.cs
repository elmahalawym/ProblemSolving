using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int makingAnagrams(string s1, string s2){
        int[] hash = new int[26];
        
        for(int i=0; i<s1.Length; i++)
            hash[s1[i] - 'a']++;
        
        for(int i=0; i<s2.Length; i++)
            hash[s2[i] - 'a']--;
        
        return hash.Select(i => Math.Abs(i)).Sum();
    }

    static void Main(String[] args) {
        string s1 = Console.ReadLine();
        string s2 = Console.ReadLine();
        int result = makingAnagrams(s1, s2);
        Console.WriteLine(result);
    }
}

