public class Solution {
    public int ClimbStairs(int n) {
        if(n == 0)
            return 0;
        if(n == 1)
            return 1;
        if(n == 2)
            return 2;
        int x = 1, y = 2;
        
        int res = 0;
        for(int i=3; i<=n; i++) {
            res = x + y;
            x = y;
            y = res;
        }
        return res;
    }
}