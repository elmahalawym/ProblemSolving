using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static string gameOfThrones(string s){
        int[] hash = new int[26];
        
        foreach(char c in s)
            hash[c-'a']++;
        
        return hash.Where(i => i%2 == 1).Count() > 1 ? "NO" : "YES";
    }

    static void Main(String[] args) {
        string s = Console.ReadLine();
        string result = gameOfThrones(s);
        Console.WriteLine(result);
    }
}
