# http://codeforces.com/problemset/problem/200/B

n = int(input())
sum = 0.0

inputs = input().split()

for i in inputs:
    sum = sum + int(i)
    
print(sum / n)