// https://leetcode.com/problems/first-bad-version/

bool isBadVersion(int version);

class Solution {
    
    int binarySearch(int min, int max) {

		int cur = ((max - min) / 2) + min;

		bool isCurBad = isBadVersion(cur);

		if (isCurBad && cur == 1)
			return 1;
		else if (isCurBad && !isBadVersion(cur - 1))
			return cur;
		else if (!isCurBad && isBadVersion(cur + 1))
			return cur + 1;

		if (isCurBad)
			return binarySearch(min, cur - 1);
		else
			return binarySearch(cur + 1, max);
	}
	
public:
    int firstBadVersion(int n) {
        return binarySearch(1, n);
    }
};