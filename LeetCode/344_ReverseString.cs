public class Solution {
    public string ReverseString(string s) {
        var arr = s.ToCharArray();
        Array.Reverse(arr);
        return new string(arr);
    }
}