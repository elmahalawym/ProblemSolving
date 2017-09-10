public class Solution {
    public int ThreeSumClosest(int[] nums, int target) {
        Array.Sort(nums);
        int minDiff = Int32.MaxValue;
        int res = 0;
        for(int i=0; i<nums.Length-2; i++) {
            int l = i+1;
            int r = nums.Length-1;
                
            while(l<r) {
                int sum = nums[i] + nums[l] + nums[r];
                int currentDiff = Math.Abs(sum - target);
                if(currentDiff < minDiff) {
                    minDiff = currentDiff;
                    res = sum;
                } 
                if(sum > target) {
                    r--;
                } else {
                    l++;
                }
            }
        }
        return res;
    }
}