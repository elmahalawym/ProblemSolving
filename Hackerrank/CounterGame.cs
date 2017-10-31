using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    
    static List<ulong> _powersOfTwo;
    
    static int Calculate(ulong n) {
        var idx = _powersOfTwo.Count-1;
        int result = 0;
        while(n > 1) {
            while(n < _powersOfTwo[idx]) { idx--; }
            if(_powersOfTwo[idx] == n) n/=2;
            else n -= _powersOfTwo[idx];
            result++;
        }
        return result;
    }
    
    static void CalculatePowersOfTwo() {
        _powersOfTwo = new List<ulong>();
        _powersOfTwo.Add(2);
        for(int i=1; i<63; i++) 
            _powersOfTwo.Add(_powersOfTwo[i-1] * 2);
    }
    
    static void Main(String[] args) {
        CalculatePowersOfTwo();
        int t = int.Parse(Console.ReadLine());
        while(t-- > 0) {
            ulong n = UInt64.Parse(Console.ReadLine());
            Console.WriteLine((Calculate(n)%2 == 0) ? "Richard" : "Louise");
        }
    }
}