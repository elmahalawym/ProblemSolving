public class Solution {
    public bool IsValid(string s) {
        
        var stack = new Stack<char>();
        
        foreach(var c in s) {
            switch(c) {
                case '(':
                case '{':
                case '[':
                    stack.Push(c);
                    break;
                case ')':
                    if(stack.Count() == 0 || stack.Peek() != '(')
                       return false;
                   stack.Pop();
                   break;
                case '}':
                    if(stack.Count() == 0 || stack.Peek() != '{')
                       return false;
                   stack.Pop();
                   break;
                case ']':
                    if(stack.Count() == 0 || stack.Peek() != '[')
                       return false;
                   stack.Pop();
                   break;
            }
        }
        
        return stack.Count() == 0;
    }
}