// https://leetcode.com/problems/rotate-array/

class Solution {
private:
	void swap(vector<int>& v, int i, int j) {
		v[i] += v[j];
		v[j] = v[i] - v[j];
		v[i] -= v[j];
	}

	void reverse(vector<int>& v, int start, int end) {
		while (start < end) {
			swap(v, start, end);
			start++;
			end--;
		}
	}

public:
	void rotate(vector<int>& nums, int k) {
		k %= nums.size();
		reverse(nums, 0, nums.size() - 1);
		reverse(nums, 0, k - 1);
		reverse(nums, k, nums.size() - 1);
	}
};
