using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        int numberOfRequests = int.Parse(Console.ReadLine());
        
        var queue = new MyQueue<int>();
        while(numberOfRequests++ > 0) {
            int[] line = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            ProcessInput(queue, line);
        }
    }
    
    static void ProcessInput(MyQueue<int> queue, int[] request) {
        switch(request[0]) {
            case 1:
                queue.Enqueue(request[1]);
                break;
            case 2:
                queue.Dequeue();
                break;
            case 3:
                Console.WriteLine(queue.GetFront());
                break;
            default:
                break;
        }
    }
}


public class MyQueue<T> {
    private Stack<T> _stack1 = new Stack<T>();
    private Stack<T> _stack2 = new Stack<T>();
    
    public void Enqueue(T obj) {
        _stack1.Push(obj);
    }
    
    public T Dequeue() {
        MoveElementsToStack2IfNecessary();
        return _stack2.Pop();
    }
    
    private void MoveElementsToStack2IfNecessary() {
        if(_stack2.Count == 0)
            PushStack1ToStack2();
    }
    
    private void PushStack1ToStack2() {
        while(_stack1.Count > 0) {
            _stack2.Push(_stack1.Pop());
        }
    }
    
    public T GetFront() {
        MoveElementsToStack2IfNecessary();
        return _stack2.Peek();
    }
    
}