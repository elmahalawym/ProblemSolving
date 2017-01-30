#include <utility>
#include <unordered_map>
using namespace std;

class Solution {
public:
    vector<int> twoSum(vector<int>& numbers, int target) {
        unordered_map<int, int> map;
        
        for(int i=0; i<numbers.size(); i++) {
            unordered_map<int, int>::const_iterator search = map.find(target - numbers[i]);
            if(search == map.end()) {
                map.insert(make_pair(numbers[i], i));
            } else {
                vector<int> result;
                result.push_back(search->second);
                result.push_back(i);
                return result;
            }
        }
        
        return vector<int>();
    }
};