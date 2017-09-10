public class Solution {
    
    public int LongestValidParentheses(string s) {
       
        int leftBrackets = 0, rightBrackets = 0;
        int maxLength = 0;
        
        foreach(var c in s) {
            
            if(c == '(') leftBrackets++;
            if(c == ')') rightBrackets++;
            
            if(leftBrackets == rightBrackets) {
                int curLength = rightBrackets * 2;
                if(curLength > maxLength) maxLength = curLength;
            } else if(leftBrackets < rightBrackets) {
                leftBrackets = 0;
                rightBrackets = 0;
            }
        }
        
        leftBrackets = 0;
        rightBrackets = 0;
        
        for(int i=s.Length-1; i>=0; i--) {
            char c = s[i];
            if(c == '(') leftBrackets++;
            if(c == ')') rightBrackets++;
            
         if(leftBrackets == rightBrackets) {
                int curLength = rightBrackets * 2;
                if(curLength > maxLength) maxLength = curLength;
            } else if(leftBrackets > rightBrackets) {
                leftBrackets = 0;
                rightBrackets = 0;
            }
        }
        
        return maxLength;
    }
}