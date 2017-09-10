public class Solution {

    public int MaximumSwap(int num) {
        var arr = ToArray(num).ToArray();

        for(int i=arr.Count()-1; i>0; i--) {
            int max = arr[i];
            int maxId = i;
            for(int j=0; j<i; j++)
            if(arr[j] > max) {
                maxId = j;
                max = arr[j];
            }
            
            if(maxId != i) {
                int temp = arr[maxId];
                arr[maxId] = arr[i];
                arr[i] = temp;
                break;
            }
        }

        return (int)ToNum(arr);
    }
    

    private IEnumerable<int> ToArray(int num) {
        List<int> result = new List<int>();
        
        while(num != 0) {
            
            result.Add(num%10);
            
            num /= 10;
        }
        return result;
    }
    
    private long ToNum(IEnumerable<int> arr) {
        int m = 1;
        long result = 0;
        for(int i=0; i<arr.Count(); i++) {
            result += (m*arr.ElementAt(i));
            m*=10;
        }
        return result;
    }
}
