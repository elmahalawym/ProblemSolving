# http://codeforces.com/problemset/problem/124/A

input = input().split()
n = int(input[0])
a = int(input[1])
b = int(input[2])

print(min(n-a, b+1))