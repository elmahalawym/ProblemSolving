public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        if(strs.Length == 0)
            return "";
        StringBuilder prefix = new StringBuilder();
        
        for(int i=0; true; i++) {
            bool includeInPrefix = true;
            
            if(strs[0].Length <= i)
                break;
            
            char c = strs[0][i];
            
            foreach(var s in strs) {
                if(s.Length <= i || s[i] != c) {
                    includeInPrefix = false;
                    break;
                }
            }
            if(includeInPrefix)
                prefix.Append(strs[0][i]);
            else
                break;
        }
        
        return prefix.ToString();
    }
}