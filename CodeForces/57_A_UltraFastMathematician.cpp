// http://codeforces.com/problemset/problem/61/A

#include <iostream>
#include <string>

using namespace std;

int main()
{
	string s1, s2;
	cin >> s1 >> s2;
	for (int i = 0; i < s1.length(); i++)
		cout << (s1[i] != s2[i]) ? "1" : "0";
	cout << endl;
}

