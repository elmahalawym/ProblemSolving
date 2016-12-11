/*
 * http://codeforces.com/problemset/problem/669/C
 * C. Little Artem and Matrix
 */


#include <iostream>
#include <stdio.h>

using namespace std;

int rShifts[101];
int cShifts[101];
int matrix[101][101];

int main()
{
    freopen("input.txt", "r", stdin);
    int n, m, q;
    cin >> n >> m >> q;

    for(int i=0; i<101; i++) {
        rShifts[i] = 0;
        cShifts[i] = 0;
    }
    for(int i=0; i<101; i++)
        for(int j=0; j<101; j++)
            matrix[i][j] = 1;

    while(q--) {
        int type;
        cin >> type;
        if(type == 1) {
            int row;
            cin >> row;
            rShifts[row]++;
        }
        else if (type == 2) {
            int col;
            cin >> col;
            cShifts[col]++;
        } else if (type == 3) {
            int r, c, v;
            cin >> r >> c >> v;

            int x = (r + rShifts[r]) % (n+1);
            int y = (c + cShifts[c]) % (m+1);
            //cout << "matrix[" << (x == 0 ? 1 : x) << "][" << (y == 0 ? 1 : y) << "] = " << v << endl;
            matrix[x == 0 ? 1 : x][y == 0 ? 1 : y] = v;
        }
    }

    for (int i = 1; i<=m; i++) {
        cout << matrix[1][i];
        for(int j=2; j<=n; j++) {
            cout << " " << matrix[j][i];
        }
        cout << endl;
    }

/*
    cout << "RShifts" << endl;
    for(int i=1; i<=n; i++)
        cout << rShifts[i] << " ";
    cout << endl;
    cout << "LShifts" << endl;
    for(int i=1; i<=m; i++)
        cout << cShifts[i] << " ";
    cout << endl;
*/
    return 0;
}
