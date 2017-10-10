using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static string funnyString(string s){
        for(int i=s.Length/2; i>0; i--) {
            if(Math.Abs(s[i] - s[i-1]) != Math.Abs(s[s.Length-i] - s[s.Length-i-1]))
                return "Not Funny";
        }
        return "Funny";
    }

    static void Main(String[] args) {
        int q = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < q; a0++){
            string s = Console.ReadLine();
            string result = funnyString(s);
            Console.WriteLine(result);
        }
    }
}
