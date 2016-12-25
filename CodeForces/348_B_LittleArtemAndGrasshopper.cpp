// http://codeforces.com/problemset/problem/669/B

#include <iostream>
#include <memory.h>
using namespace std;

#define INPUT_SIZE 100001

bool directions[INPUT_SIZE];
int lengths[INPUT_SIZE];
bool visited[INPUT_SIZE];

int main()
{
    int n;
    cin >> n;
    for(int i=0; i<n; i++) {
        char d;
        cin >> d;
        directions[i+1] = d == '<';
        visited[i+1] = false;
    }

    for(int i=0; i<n; i++) {
        int l;
        cin >> l;
        lengths[i+1] = l;
    }

    int cur = 1;
    visited[cur] = true;
    string result = "FINITE";

    while(true) {
        int nextLocation = directions[cur] ? cur - lengths[cur] : cur + lengths[cur];
        if(nextLocation < 1 || nextLocation > n) {
            cout << "FINITE" << endl;
            return 0;
        }
        if(visited[nextLocation]) {
            cout << "INFINITE" << endl;
            return 0;
        }
        cur = nextLocation;
        visited[cur] = true;
    }

    return 0;
}
