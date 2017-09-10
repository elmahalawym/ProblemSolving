using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static string twoStrings(string s1, string s2){
        var hash = new HashSet<char>();
        
        foreach(var c in s1) 
            hash.Add(c);
        
        foreach(var c in s2)
            if(hash.Contains(c))
                return "YES";
        return "NO";
    }

    static void Main(String[] args) {
        int q = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < q; a0++){
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            string result = twoStrings(s1, s2);
            Console.WriteLine(result);
        }
    }
}
