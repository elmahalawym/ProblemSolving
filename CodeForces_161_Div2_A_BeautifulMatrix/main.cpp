#include <iostream>
#include <vector>

using namespace std;

int abs(int x)
{
    if(x < 0)
        return x*-1;
    else
        return x;
}

int main() {
    int arr[5][5];
    int x, y;
    for(int i=0; i<5; i++)
    {
        for(int j=0; j<5; j++)
        {
            cin >> arr[i][j];
            if(arr[i][j] == 1)
            {
                x = i; y = j;
            }
        }
    }
    cout << abs(x-2) + abs(y-2) << endl;
    return 0;
}