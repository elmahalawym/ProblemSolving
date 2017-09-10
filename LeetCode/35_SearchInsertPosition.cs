public class Solution {
    
    public int SearchInsert(int[] nums, int target) {
    
        int start = 0;
        int end = nums.Length-1;
        int median = -1;
        
        while(start <= end) {
            median = (start + end) / 2;
            
            if(nums[median] == target) return median;
            
            if(nums[median] < target) {
                start = median + 1;
            } else {
                end = median - 1;
            }
        }
        
        return nums[median] > target ? median : median + 1;
    }
    
}