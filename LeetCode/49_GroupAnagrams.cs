public class Solution {
    private string SortString(string s) {
        var chars = s.OrderBy(c => c).ToArray();
        return new string(chars);
    }
    
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        if(strs.Length == 0) return new List<IList<string>>();
        var dictionary = new Dictionary<string, List<string>>();
       
        foreach(var str in strs) {
            var sortedString = SortString(str);
            
            if(!dictionary.ContainsKey(sortedString))
                dictionary[sortedString] = new List<string>();
            
            dictionary[sortedString].Add(str);   
        }
        
        var result = new List<IList<string>>();
        
        foreach(var item in dictionary) 
            result.Add(item.Value);
        
        return result;
    }
}