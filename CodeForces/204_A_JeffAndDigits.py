# http://codeforces.com/problemset/problem/352/A

import sys

def main():
    n = int(input())
    numberOfFives = 0
    numberOfZeros = 0
    inputs = str(input()).split()

    for i in range(n):
        if int(inputs[i]) == 5:
            numberOfFives = numberOfFives + 1
        else:
            numberOfZeros = numberOfZeros + 1

    if numberOfZeros == 0:
        print(-1)
    elif numberOfFives < 9:
        print(0)
    else:
        numberOfFives = GetMaxFives(numberOfFives)
        for i in range(numberOfFives):
            sys.stdout.write('5')
        for i in range(numberOfZeros):
            sys.stdout.write('0')
    print()

def GetMaxFives(numberOfFives):
    i = numberOfFives
    while i > 8:
        if(int('5'*i) % 9 == 0):
            return i
        i = i -1

if __name__ == '__main__': main()