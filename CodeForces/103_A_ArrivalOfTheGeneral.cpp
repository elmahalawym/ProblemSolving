// http://codeforces.com/problemset/problem/144/A?locale=en
//

#include <cstdio>
#include <vector>
using namespace std;

int main(void)
{
    int n; //number of soldiers
    scanf("%d", &n);
    vector<int> heights;
    for(int i=0; i<n; i++)
    {
        int entry;
        scanf("%d", &entry);
        heights.push_back(entry);
    }
    //calculating the index of the minimum and maximum numbers in the heights
    int maxIndex, max = 0;
    int minIntex, min = 1<<28;
    for(int i=0; i<n; i++)
    {
        if(heights[i] > max)
        {
            max = heights[i];
            maxIndex = i;
        }
        if(heights[i] <= min)
        {
            min = heights[i];
            minIntex = i;
        }
    }
    int result =  maxIndex + n - 1 - minIntex;
    if(maxIndex > minIntex)
        result =  maxIndex + n - 2 - minIntex;
    printf("%d\n", result);
    return 0;
}