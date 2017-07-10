using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        int n = int.Parse(Console.ReadLine());
        List<string> inputLines = new List<string>();
        while(n-- > 0) {
            inputLines.Add(Console.ReadLine());
        }
        
        int t = int.Parse(Console.ReadLine());
        while(t-- > 0) {
            Console.WriteLine(CountNumberOfOccurances(inputLines, Console.ReadLine()));
        }
    }
    
    static int CountNumberOfOccurances(List<string> lines, string usVersion) {
        string britishVersion = ToBritishVersion(usVersion);
        
        int count = 0;
        
        foreach(var line in lines) {
            var words = line.Split();
            foreach(var word in words) {
                if (word == usVersion || word == britishVersion)
                    count++;
            }
        }
        
        return count;
    }
    
    static string ToBritishVersion(string usVersion) {
        var charArray = usVersion.ToCharArray();
        charArray[charArray.Length-2] = 's';
        return new string(charArray);
    }
    
    
}