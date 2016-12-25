// http://codeforces.com/problemset/problem/155/A

#include <iostream>

using namespace std;

int main()
{
	int n, max, min, res = 0;
	cin >> n;
	for (int i = 0; i < n; i++)
	{
		int cur;
		cin >> cur;

		if (i == 0)
		{
			max = cur;
			min = cur;
		}
		else if (cur > max)
		{
			max = cur;
			res++;
		}
		else if (cur < min)
		{
			min = cur;
			res++;
		}
	}
	cout << res << endl;
	return 0;
}

