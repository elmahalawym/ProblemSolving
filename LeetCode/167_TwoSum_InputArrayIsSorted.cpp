#include <utility>
#include <unordered_map>
using namespace std;

class Solution {
public:
    vector<int> twoSum(vector<int>& numbers, int target) {
        int min = 0;
        int max = numbers.size()-1;
        
        while(max > min) {
            int sum = numbers[max] + numbers[min];
            
            if(sum == target) {
                vector<int> result;
                result.push_back(min+1);
                result.push_back(max+1);
                return result;
            } else if(sum > target) {
                max--;
            } else {
                min++;
            }
        }
        
        return vector<int>();
    }
};