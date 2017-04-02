// https://leetcode.com/problems/minimum-moves-to-equal-array-elements/

#include <climits>
#include <cmath>
#include <algorithm>

class Solution {
public:
    int minMoves(vector<int>& nums) {
        
        sort(nums.begin(), nums.end());
        
        vector<int> diffs;
        
        for(int i=0; i<nums.size()-1; i++)
            diffs.push_back(nums[i+1] - nums[i]);
        
        for(int i=1; i<diffs.size(); i++) 
            diffs[i] = diffs[i] + diffs[i-1];
        
        int result = 0;
        for(int i=0; i<diffs.size(); i++)
            result += diffs[i];
            
        return result;
    }
};