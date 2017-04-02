// http://codeforces.com/contest/766/problem/A
// A. Mahmoud and Longest Uncommon Subsequence

#include <iostream>
#include <string>
#include <vector>
using namespace std;

int main() {
	string a, b;
	cin >> a >> b;
	int aLen = a.length(), bLen = b.length();
	if (aLen > bLen)
		cout << aLen << endl;
	else if (aLen < bLen)
		cout << bLen << endl;
	else if (aLen == bLen) {
		if (a == b)
			cout << -1 << endl;
		else
			cout << aLen << endl;
	}
}