public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        var sortedArray = GetSortedArray(nums1, nums2, (nums1.Length + nums2.Length) / 2);
        if((nums1.Length + nums2.Length)%2 == 1) {
            return sortedArray[sortedArray.Length-1];            
        } else {
            return (double)(sortedArray[sortedArray.Length-1] + sortedArray[sortedArray.Length-2]) / 2;
        }
    }
    
    private int[] GetSortedArray(int[] nums1, int[] nums2, int until) {
        int n1 = 0, n2 = 0;
        
        int[] result = new int[until+1];
        for(int i=0; i<=until; i++) {
            if(n1 >= nums1.Length)
                result[i] = nums2[n2++];
            else if(n2 >= nums2.Length)
                result[i] = nums1[n1++];
            else if(nums1[n1] < nums2[n2])
                result[i] = nums1[n1++];
            else 
                result[i] = nums2[n2++];
            
        }
        
        return result;
    }
}