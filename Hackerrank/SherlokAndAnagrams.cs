// https://www.hackerrank.com/challenges/sherlock-and-anagrams


using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        int t = int.Parse(Console.ReadLine());
        while(t-- > 0) {
            Console.WriteLine(Solve(Console.ReadLine()));
        }
    }
    
    static int Solve(string s) {
        int count = 0;
        for(int i=0; i<s.Length; i++) {
            for(int j=i; j<s.Length; j++) {
                string s1 = s.Substring(i, j-i+1);
                for(int k=i+1; k+(j-i) < s.Length; k++) {     
                    string s2 = s.Substring(k, j-i+1);
                    if(IsAnagram(s1, s2))
                        count++;
                }
            }
        }
        return count;
    }
    
    static bool IsAnagram(string s1, string s2) {
        if(s1.Length != s2.Length)
            return false;
        
        int[] arr = new int[26];
        for(int i=0; i<s1.Length; i++) {
            arr[s1[i] - 'a']++;
        }
        
        for(int i=0; i<s2.Length; i++) {
            arr[s2[i] - 'a']--;
        }
        
        for(int i=0; i<26; i++)
            if(arr[i] != 0)
                return false;
        return true;
    }
}