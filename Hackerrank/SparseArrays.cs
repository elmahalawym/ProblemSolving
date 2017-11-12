using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        
        int n = int.Parse(Console.ReadLine());
        Dictionary<string, int> map = new Dictionary<string, int>();
        
        for(int i=0; i<n; i++) 
            AddKey(map, Console.ReadLine());    
        
        int q = int.Parse(Console.ReadLine());
        
        for(int i=0; i<q; i++) {
            string key = Console.ReadLine();
            
            if(map.ContainsKey(key))
                Console.WriteLine(map[key]);
            else
                Console.WriteLine(0);
        }
    }
    
    static void AddKey(Dictionary<string, int> map, string key) {
        if(map.ContainsKey(key))
            map[key]++;
        else
            map[key] = 1;
    }
}