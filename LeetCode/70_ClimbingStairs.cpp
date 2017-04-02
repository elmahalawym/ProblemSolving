class Solution {
    
    long climbStairs(int n, unordered_map<int, long>& map) {
        
       if(n == 0)
            return 1;
        
        if(n < 0)
            return 0;
     
        auto search = map.find(n);
        if(search != map.end())
            return search->second;
        
        long ans = climbStairs(n-1, map) + climbStairs(n-2, map);
        map[n] = ans;
        return ans;
    }
    
public:

    long climbStairs(int n) {
        unordered_map<int, long> map;
        return climbStairs(n, map);

    }
};