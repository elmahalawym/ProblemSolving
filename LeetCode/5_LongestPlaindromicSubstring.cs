public class Solution {

    // expand around center
    public string LongestPalindrome(string s) {
        
        int start=0, end=0;
        
        for(int i=0; i<s.Length; i++) {
            var sub1 = ExpandAround(s, i, i);
            var sub2 = ExpandAround(s, i, i+1);
            
            if(sub1.Item2-sub1.Item1 > end-start) {
                start = sub1.Item1;
                end = sub1.Item2;
            }

            if(sub2.Item2-sub2.Item1 > end-start) {
                start = sub2.Item1;
                end = sub2.Item2;
            }
        }

        return s.Substring(start, end-start+1);
    }

    Tuple<int, int> ExpandAround(string s, int left, int right) {
        while(left >=0 && right>=0 && left <s.Length && right < s.Length && s[right] == s[left]) {
            right++;
            left--;
        }
        left++;
        right--;
        if(left >=0 && right>=0 && left <s.Length && right < s.Length)
            return Tuple.Create(left, right);
        return Tuple.Create<int, int>(0, 0);
    }

/*
    // using dynamic programming
    public string LongestPalindrome(string s) {
        
        if(s == "") return "";
        
        bool[,] dp = new bool[s.Length, s.Length];
        
        string maxPlaindrome = s[0].ToString();
        
        for(int i=0; i<s.Length; i++)
            dp[i,i] = true;
        
        for(int i=0; i<s.Length-1; i++){
            if(s[i] == s[i+1]) {
                dp[i,i+1] = true;
                if(maxPlaindrome.Length < 2)
                    maxPlaindrome = s.Substring(i, 2);
            }
        }
    
        for(int k = 3; k <= s.Length; k++) {
            for(int i=0; i<s.Length-k+1; i++) {
                // solve for substring i, i+k-1
                int j = i+k-1;
                dp[i,j] = s[i] == s[j] &&
                    dp[i+1,j-1];
                if(dp[i,j]) {
                    if(k > maxPlaindrome.Length) {
                        maxPlaindrome = s.Substring(i, k);
                    }
                }
            }
        }
        
        return maxPlaindrome;
    }
*/
}