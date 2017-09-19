public class Solution {
    public int MaxSubArray(int[] nums) {
        int maxSofar = nums[0];
        int curMax = nums[0];
        for(int i=1; i<nums.Length; i++) {
            curMax = Math.Max(curMax + nums[i], nums[i]);
            maxSofar = Math.Max(curMax, maxSofar);
        }
        return maxSofar;
    }
}