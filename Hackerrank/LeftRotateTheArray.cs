using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {
    static void Main(String[] args) {
        var input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        
        var array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        
        int d = input[1] % array.Length;
        for(int i=d; i<array.Length; i++)
            Console.Write(array[i] + " ");
        for(int i=0; i<d; i++)
            Console.Write(array[i] + " ");
    }
}