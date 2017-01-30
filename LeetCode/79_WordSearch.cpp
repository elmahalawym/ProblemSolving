class Solution {

    bool solve(vector<vector<char>>& board, string& word, int position, int x, int y, vector<vector<bool>>& visited) {
        if(word[position] != board[x][y])
            return false;
        
        visited[x][y] = true;
        
        position++;
        
        if(position == word.length())
            return true;
        
        bool result = (x > 0 && !visited[x-1][y] && solve(board, word, position, x-1, y, visited)) ||
               (x < board.size()-1) && !visited[x+1][y] && solve(board, word, position, x+1, y, visited) ||
               (y > 0 && !visited[x][y-1] && solve(board, word, position, x, y-1, visited)) ||
               (y < board[0].size()-1 && !visited[x][y+1] && solve(board, word, position, x, y+1, visited));
        
        visited[x][y] = false;       
               
        return result;
    }
    
public:
    bool exist(vector<vector<char>>& board, string word) {
        vector<vector<bool>> visited;
        visited.resize(board.size());
        
        for(int i=0; i<board.size(); i++) {
            visited[i].resize(board[0].size());
            for(int j=0; j<visited[i].size(); j++) {
                visited[i][j] = false;
            }
        }
        
        for(int i=0; i<board.size(); i++) {
            for(int j=0; j<board[0].size(); j++) {
                if(solve(board, word, 0, i, j, visited))
                    return true;
            }
        }
        return false;
    }
};