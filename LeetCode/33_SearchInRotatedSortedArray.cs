public class Solution {
    
    public int Search(int[] nums, int target) {
        
        if(nums.Length == 0)
            return -1;
        
        int arrayEnd = FindArrayEnd(nums);
      
        if(arrayEnd == -1)
            return BinarySearch(nums, 0, nums.Length-1, target);
        
        if(target == nums[arrayEnd])
            return arrayEnd;
        
        if(target >= nums[0])
            return BinarySearch(nums, 0, arrayEnd-1, target);
        
        return BinarySearch(nums, arrayEnd+1, nums.Length-1, target);
    }
    
    private int FindArrayEnd(int[] nums) {
        int start = 0, end = nums.Length-1;
        
        while(start <= end) {
            if(start == end) return start;
            int median = (start + end) / 2;
            if(median < end && nums[median] > nums[median+1]) return median;
            if(median > start && nums[median] < nums[median-1]) return median-1;
            if(nums[median] > nums[start]) start = median+1;
            else end = median-1;
        }
        
        return -1;
    }
    
    private int BinarySearch(int[] nums, int start, int end, int target) {
        while(start <= end) {
            int median = (start + end) / 2;
            if(nums[median] == target) return median;
            else if(nums[median] < target) start = median + 1;
            else
                end = median - 1;
        }
        return -1;
    }
}