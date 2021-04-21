#!/bin/python3

import os
import sys

#
# Complete the getMoneySpent function below.
#
def getMoneySpent(keyboards, drives, b):
    for i in keyboards:
        if i>=b:
            keyboards.remove(i)
    for i in drives:
        if i>=b:
            drives.remove(i)
    
    if len(keyboards) == 0 or len(drives)==0:
        return -1
    cost_list =[]
    for i in keyboards:
        for j in drives:
            if i+j <=b:
                cost_list.append(i+j)
    if len(cost_list)!=0:
        return max(cost_list)
        #I didn't think of a scenario where max may get a empty list itself.
        # thus my logic failed.
        #make sure to adjust for / check for empty scenarios in aggregate methods
    else:
        return -1
    

if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    bnm = input().split()

    b = int(bnm[0])

    n = int(bnm[1])

    m = int(bnm[2])

    keyboards = list(map(int, input().rstrip().split()))

    drives = list(map(int, input().rstrip().split()))

    #
    # The maximum amount of money she can spend on a keyboard and USB drive, or -1 if she can't purchase both items
    #

    moneySpent = getMoneySpent(keyboards, drives, b)

    fptr.write(str(moneySpent) + '\n')

    fptr.close()
