// http://codeforces.com/problemset/problem/59/A
#include <iostream>
#include <string>
#include <algorithm>
#include <stdio.h>

using namespace std;

int main()
{
   // freopen("input.txt", "r", stdin);
    string s;
    cin >> s;
    int nL = 0, nU = 0;
    for(int i=0; i<s.length(); i++) {
        if(s[i] >= 'a' && s[i] <= 'z')
            nL++;
        else
            nU++;
    }
    bool toLower = nL >= nU;
    for(int i=0; i<s.length(); i++) {
        if(toLower)
            transform(s.begin(), s.end(), s.begin(), ::tolower);
        else
            transform(s.begin(), s.end(), s.begin(), ::toupper);
    }
    cout << s << endl;
    return 0;
}
