// http://codeforces.com/problemset/problem/129/A
//

#include <iostream>
#include <vector>

using namespace std;


int main()
{
	int n, sum = 0, res = 0;
	vector<int> v;
	cin >> n;
	while (n--)
	{
		int input;
		cin >> input;
		v.push_back(input);
		sum += input;
	}
	for (int i = 0, l = v.size(); i < l; i++)
		if ((sum - v[i]) % 2 == 0) res++;
	cout << res << endl;
	return 0;
}

