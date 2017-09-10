public class Solution {

    public IList<int> FindAnagrams(string s, string p) {
        var result = new List<int>();
        
        for(int i=0; i<s.Length-p.Length+1; i++) {
            if(AreAnagrams(s.Substring(i, p.Length), p))
            result.Add(i);
        }

        return result;
    }

    private bool AreAnagrams(string s1, string s2) {
        if(s1.Length != s2.Length)
            return false;

        var hash = new int[26];

        foreach(var c in s1) 
            hash[c-'a']++;

        foreach(var c in s2) {
            hash[c-'a']--;
            if(hash[c-'a'] < 0)
                return false;
        }

        return hash.All(i => i == 0);
    }
}