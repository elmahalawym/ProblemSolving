// http://codeforces.com/problemset/problem/32/B

#include <iostream>
#include <stdio.h>
#include <string>
using namespace std;

int main()
{
    freopen("input.txt", "r", stdin);

    string s;
    cin >> s;

    for(int i=0; i<s.length(); i++) {
        switch(s[i]) {
        case '.':
            cout << "0";
            break;
        case '-':
            if(s[i+1] == '-')
                cout << "2";
            else
                cout << "1";
            i++;
            break;
        }
    }

    return 0;
}
