# http://codeforces.com/problemset/problem/334/A

import sys

x = int(input())
x2 = int(x**2)

groups = []

for i in range(int(x2/2)):
    groups.append([i+1, x2-i])

i = 0
for g in groups:
    sys.stdout.write(str(g[0]) + ' ' + str(g[1]) + ' ')
    i = i + 2
    if i == x:
        sys.stdout.write('\n')
        i = 0
    