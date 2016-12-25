// http://codeforces.com/problemset/problem/669/A

#include <iostream>

using namespace std;


int main() {
    int result = 0;
    int present = 0;
    int N;
    cin >> N;

    while(N > 0){
        int nextPresent = (present != 1) ? 1 : 2;
        N -= nextPresent;
        present = nextPresent;
        if(N >= 0)
            result++;
    }

    cout << result << endl;
    return 0;
}
