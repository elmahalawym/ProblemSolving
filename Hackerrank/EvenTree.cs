// https://www.hackerrank.com/challenges/even-tree

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Node {
    public Node(int val) {
        Children = new List<Node>();
        Value = val;
    }
    public int Value {get;set;}
    public List<Node> Children {get; set;}
    public int SubTreeCount {get; set;}
}

class Solution {
    static void Main(String[] args) {
        int[] firstLine = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int n = firstLine[0];
        int m = firstLine[1];
        
        Node[] nodes = new Node[n+1];
        for(int i=1; i<nodes.Length; i++) 
            nodes[i] = new Node(i);
        
        for(int i=0; i<m; i++) {
            int[] line = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            nodes[line[1]].Children.Add(nodes[line[0]]);
        }
        
        UpdateSubTreeCount(nodes[1]);
        Console.WriteLine(Solve(nodes[1]));
    }
    
    static int Solve(Node root) {

        int res = 0;
        foreach(var n in root.Children) {
            if(n.SubTreeCount%2 == 0) {
                res += 1 + Solve(n);
            } else {
                res += Solve(n);
            }
        }
        
        return res;
    }
    
    static void UpdateSubTreeCount(Node root) {
        
        foreach(var n in root.Children) {
            UpdateSubTreeCount(n);
        }
        
        root.SubTreeCount = 1 + root.Children.Sum(r => r.SubTreeCount);
    }
    
}