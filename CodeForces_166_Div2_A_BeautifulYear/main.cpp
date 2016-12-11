#include <iostream>
#include <string>
#include <sstream>
#include <stdio.h>

using namespace std;

int stringToInt(string s) {
    stringstream ss;
    ss << s;
    int i;
    ss >> i;
    return i;
}

string intToString(int i) {
    stringstream ss;
    ss << i;
    return ss.str();
}

bool isDistinctDigits(string s) {
    for(int i=0; i<s.length(); i++) {
        for(int j=i+1; j<s.length(); j++) {
            if(s[i] == s[j]) return false;
        }
    }
    return true;
}

int main()
{
    freopen("input.txt", "r", stdin);
    string s;
    cin >> s;

    while(true) {
        s = intToString(stringToInt(s) + 1);
        if(isDistinctDigits(s)) {
            cout << s << endl;
            break;
        }
    }

    return 0;
}
