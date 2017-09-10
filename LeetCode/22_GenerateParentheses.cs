public class Solution {
    
    public IList<string> GenerateParenthesis(int n) {
        var list = new List<string>();
        Solve(list, "", n, 0);
        return list;
    }
    
    private void Solve(IList<string> list, string str, int n, int m) {
        
        if(n==0 && m==0) {
            list.Add(str);
            return;
        }
        
        if(n > 0) Solve(list, str + "(", n-1, m+1);
        if(m>0) Solve(list, str + ")", n, m-1);
    }
}