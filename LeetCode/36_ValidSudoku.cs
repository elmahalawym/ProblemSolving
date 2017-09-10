public class Solution {
    
    public bool IsValidSudoku(char[,] board) {
        
        var hash = new HashSet<string>();
        
        for(int i=0; i<9; i++) {
            for(int j=0; j<9; j++) {
                
                if(board[i,j] == '.')
                    continue;
                
                var s1 = $"{board[i,j]} in row {i}";
                var s2 = $"{board[i,j]} in column {j}";
                var s3 = $"{board[i,j]} in region {i/3},{j/3}";
                
                if(hash.Contains(s1) || hash.Contains(s2) || hash.Contains(s3))
                    return false;
                
                hash.Add(s1);
                hash.Add(s2);
                hash.Add(s3);
            }
        }
        
        return true;
    }
}