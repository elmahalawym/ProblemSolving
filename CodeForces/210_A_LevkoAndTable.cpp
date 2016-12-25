// http://codeforces.com/problemset/problem/361/A
//

#include <iostream>

using namespace std;

int main()
{
	int n, k;
	cin >> n >> k;

	int start = 0;
	for (int i = 0; i < n; ++i)
	{
		for (int j = 0; j < n; ++j)
		{
			cout << ((j == start) ? k : 0) << " ";
		}
		start++;
		start %= n;
		cout << endl;
	}

	return 0;
}