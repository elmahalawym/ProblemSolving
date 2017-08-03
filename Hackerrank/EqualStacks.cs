using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {
    
    static Stack<int> _stack1;
    static Stack<int> _stack2;
    static Stack<int> _stack3;

    static void Main(String[] args) {

        ReadInputFromConsole();
        
        while(!StacksAreEqualHeight()) {
            GetLongestStack().Pop();
        }
        
        Console.WriteLine(GetStackHeight(_stack1));
    }

    static void ReadInputFromConsole() {
        string[] tokens_n1 = Console.ReadLine().Split(' ');
        int n1 = Convert.ToInt32(tokens_n1[0]);
        int n2 = Convert.ToInt32(tokens_n1[1]);
        int n3 = Convert.ToInt32(tokens_n1[2]);
        string[] h1_temp = Console.ReadLine().Split(' ');
        int[] h1 = Array.ConvertAll(h1_temp,Int32.Parse);
        string[] h2_temp = Console.ReadLine().Split(' ');
        int[] h2 = Array.ConvertAll(h2_temp,Int32.Parse);
        string[] h3_temp = Console.ReadLine().Split(' ');
        int[] h3 = Array.ConvertAll(h3_temp,Int32.Parse);

        _stack1 = GetStack(h1);
        _stack2 = GetStack(h2);
        _stack3 = GetStack(h3);
    }
    
    
    static bool StacksAreEqualHeight() {
        return GetStackHeight(_stack1) == GetStackHeight(_stack2) &&
            GetStackHeight(_stack2) == GetStackHeight(_stack3);
    }
    
    static int GetStackHeight(Stack<int> stack) {
        return stack.Count() > 0 ? stack.Peek() : 0;
    }
    
    static Stack<int> GetLongestStack() {
        Stack<int> longestOfOneAndTwo = GetStackHeight(_stack1) > GetStackHeight(_stack2) ?
            _stack1 : _stack2;
        return GetStackHeight(longestOfOneAndTwo) > GetStackHeight(_stack3) ?
            longestOfOneAndTwo : _stack3;
    }
    
    
    static Stack<int> GetStack(int[] arr) {
        var stack = new Stack<int>();

        if(arr.Length == 0)
            return stack;

        stack.Push(arr[arr.Length-1]);
        for(int i=arr.Length-2; i>=0; i--)
            stack.Push(arr[i] + stack.Peek());

        return stack;
    }
}
