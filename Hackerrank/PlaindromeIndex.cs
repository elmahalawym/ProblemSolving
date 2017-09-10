using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    // abcb
    // aabbcc

    static bool IsPlaindrome(string s) {
        for(int i=0; i<s.Length/2; i++) {
            if(s[i] != s[s.Length-1-i])
                return false;
        }
        return true;
    }
    
    static int palindromeIndex(string s){
        
        if(IsPlaindrome(s))
            return -1;

        for(int i=0; i<s.Length/2; i++) {
            if(s[i] != s[s.Length-1-i]) {
                if(IsPlaindrome(s.Remove(i, 1)))
                    return i;
                if(IsPlaindrome(s.Remove(s.Length-1-i, 1)))
                    return s.Length-1-i;
                return -1;
            }
        }
        return -1;
    }

    static void Main(String[] args) {
        int q = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < q; a0++){
            string s = Console.ReadLine();
            int result = palindromeIndex(s);
            Console.WriteLine(result);
        }
    }
}
