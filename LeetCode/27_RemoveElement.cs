public class Solution {
    
    public int RemoveElement(int[] nums, int val) {
        int id = 0;
        for(int i=0; i<nums.Length; i++) {
            if(nums[i] != val) {
                nums[id++] = nums[i];
            }
        }
        return id;
    }
}