//============================================================================
// Name        : .cpp
// Author      : me
// Version     :
// Copyright   : 
// Description : http://www.codeforces.com/problemset/problem/230/A
//============================================================================

#include <iostream>
#include <vector>
#include <stdio.h>
#include <stdlib.h>
using namespace std;

int main() {
    int s, n;
    cin >> s >> n;
    vector<pair<int, int> > dragons;
    dragons.resize(n);
    for(int i=0; i<n; i++)
    {
        cin >> dragons[i].first >> dragons[i].second;
    }
    for(int i=0; i<n-1; i++)
    {
        for(int j=0; j<n-1; j++)
        {
            if(dragons[j].first > dragons[j+1].first)
            {
                int temp1 = dragons[j].first;
                int temp2 = dragons[j].second;
                dragons[j].first = dragons[j+1].first;
                dragons[j].second = dragons[j+1].second;
                dragons[j+1].first = temp1;
                dragons[j+1].second = temp2;

            }
        }
    }
    bool canWin = true;
    for(int i=0; i<n; i++)
    {
        if(dragons[i].first >= s)
        {
            canWin = false;
            break;
        }
        else
        {
            s += dragons[i].second;
        }
    }
    if(canWin)
        cout << "YES" << endl;
    else
        cout << "NO" << endl;
    return 0;
}