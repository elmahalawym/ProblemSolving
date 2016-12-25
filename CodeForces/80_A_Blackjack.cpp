// http://codeforces.com/problemset/problem/104/A

#include <iostream>

using namespace std;


int main()
{
	int n;
	cin >> n;
	int arr[11] = {4, 4, 4, 4, 4, 4, 4, 4, 4, };
	
	int rem = n - 10;
	if (rem == 10)
		cout << 15 << endl;
	else if (rem >= 1 && rem <= 11)
		cout << 4 << endl;
	else
		cout << 0 << endl;
	return 0;
}

