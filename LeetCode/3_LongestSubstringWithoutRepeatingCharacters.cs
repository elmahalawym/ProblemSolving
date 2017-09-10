// https://leetcode.com/problems/longest-substring-without-repeating-characters/description/

public class Solution {

    public int LengthOfLongestSubstring(string s) {
                
        HashSet<int> hash = new HashSet<int>();
        
        int currentStart = 0;
        int result = 0;
        for(int i=0; i<s.Length; i++) {
            if(!hash.Contains(s[i])) {
                hash.Add(s[i]);
                int currentLength = i-currentStart+1;
                result = Math.Max(result, currentLength);
            } else {
                for(int j=currentStart; j<i; j++) {
                    if(s[j] == s[i]) {
                        currentStart = j+1;
                        break;
                    } else {
                        hash.Remove(s[j]);
                    }
                }
            }
        }
        return result;
    }
}