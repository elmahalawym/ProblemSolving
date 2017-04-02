// http://codeforces.com/contest/766/problem/B
// B. Mahmoud and a Triangle

#include <iostream>
#include <string>
#include <vector>
#include <cmath>
#include <algorithm>
using namespace std;


int main() {
	int n;
	vector<int> a;

	cin >> n;
	a.resize(n);

	for (int i = 0; i < n; i++) 
		cin >> a[i];

	sort(a.begin(), a.end());

	for (int i = 0; i < n - 2; i++) {
		if (a[i + 2] < a[i] + a[i + 1]) {
			cout << "YES" << endl;
			return 0;
		}
	}

	cout << "NO" << endl;
	return 0;
}