// http://codeforces.com/problemset/problem/282/C
//

#include <iostream>
#include <string>
using namespace std;

int main() {
	string s1, s2;
	cin >> s1 >> s2;
	if (s1.size() != s2.size()) {
		cout << "NO" << endl;
		return 0;
	}
	int ca = 0, cb = 0;
	for (int i = 0; i < s1.size(); i++) {
		if (s1[i] == '1') ca++;
		if (s2[i] == '1') cb++;
		if (ca > 0 && cb > 0) {
			cout << "YES" << endl;
			return 0;
		}
	}
	
	if (ca == 0 && cb == 0) {
		cout << "YES" << endl;
		return 0;
	}

	cout << "NO" << endl;
	return 0;
}