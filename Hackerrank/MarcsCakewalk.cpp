// https://www.hackerrank.com/challenges/marcs-cakewalk

#include <cmath>
#include <cstdio>
#include <vector>
#include <iostream>
#include <algorithm>
#include <queue>
#include <functional>
using namespace std;


int main() {
    int n;
    cin >> n;
    priority_queue<int, vector<int>, less<int>> q;
    for(int i = 0; i < n; i++){
        int c;
        cin >> c;
        q.push(c);
    }
    
    long long ans = 0;
    int count = 0;
    while(!q.empty()) {
        int c = q.top();
        ans += (c * pow(2, count++));
        q.pop();
    }
    cout << ans << endl;
    
    
    
    return 0;
}
