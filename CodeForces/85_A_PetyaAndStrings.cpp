// http://codeforces.com/problemset/problem/112/A

#include <iostream>
#include <string.h>
#include <cstdio>

using namespace std;

void ToUpper(char* s);

int main(void)
{
	char s1[100], s2[100];
	cin >> s1 >> s2;
	ToUpper(s1);
	ToUpper(s2);
	printf("%d\n",strcmp(s1, s2));
	return 0;
}

void ToUpper(char* s)
{
	int len = 100;
	for(int i=0; i<len; i++)
	{
		if(s[i] >= 'a' && s[i] <= 'z')
			s[i] -= ('a' - 'A');
	}
}