public class Solution {
    
    public IList<IList<int>> ThreeSum(int[] nums) {
        var result = new List<IList<int>>();
        Array.Sort(nums);
        
        for(int i=0; i<nums.Length; i++) {
            
            if(i>0 && nums[i] == nums[i-1])
                continue;
            
            int l = i+1, r=nums.Length-1;
            while(r > l) {
                int sum = nums[i] + nums[r] + nums[l];
                if(sum > 0)
                    r--;
                else if(sum < 0)
                    l++;
                else{
                    result.Add(new [] { nums[i], nums[r], nums[l] });
                    while(l < r && nums[l] == nums[l+1])
                        l++;
                    while(l < r && nums[r] == nums[r-1])
                        r--;    
                    l++;
                    r--;
                }
            }
        }
        return result;
    }
}