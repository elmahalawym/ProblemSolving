# http://codeforces.com/contest/749/problem/A

import sys

n = int(input())
res = int(n/2)
print(res)
if n%2 == 0:
    for i in range(res):
        sys.stdout.write('2 ')
    sys.stdout.write('\n')
else:
    for i in range(res - 1):
        sys.stdout.write('2 ')
    sys.stdout.write('3\n')