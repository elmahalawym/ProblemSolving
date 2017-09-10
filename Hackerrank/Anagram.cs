using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int anagram(string s){
        
        if(s.Length % 2 == 1)
            return -1;
        
        int[] hash = new int[256];
        
        for(int i=0; i<s.Length/2; i++) 
            hash[s[i]]++;
        
        for(int i=s.Length/2; i<s.Length; i++) {
            hash[s[i]]--;
        }
        
        return hash.Select(i => Math.Abs(i)).Sum() / 2;
    }

    static void Main(String[] args) {
        int q = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < q; a0++){
            string s = Console.ReadLine();
            int result = anagram(s);
            Console.WriteLine(result);
        }
    }
}
