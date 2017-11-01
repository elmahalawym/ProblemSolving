using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    
    static int CalculateNumberOfGroups(int[] weights) {
        
        if(weights.Length == 0)
            return 0;
        
        Array.Sort(weights);
        
        int lastWeight = weights[0];
        int result = 1;
        
        for(int i=1; i<weights.Length; i++) {
            if(weights[i] - lastWeight <= 4)
                continue;
            
            lastWeight = weights[i];
            result++;
        }
        
        return result;
    }
    
    static void Main(String[] args) {
        int n = int.Parse(Console.ReadLine());
        int[] weights = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        Console.WriteLine(CalculateNumberOfGroups(weights));
    }
}
