// http://codeforces.com/problemset/problem/69/A

#include <iostream>
#include <stdio.h>

using namespace std;

int main()
{
    freopen("input.txt", "r", stdin);
    int n, X = 0, Y = 0, Z = 0;
    cin >> n;
    while(n--) {
        int x, y, z;
        cin >> x >> y >> z;
        X += x;
        Y += y;
        Z += z;
    }
    cout << ((X == 0 && Y == 0 && Z == 0) ? "YES" : "NO") << endl;
    return 0;
}
