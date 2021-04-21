
# bill=[2, 4, 6]
# print(bill)
# k=bill.pop(0)
# print(bill)
# print(k)


#!/bin/python3

import math
import os
import random
import re
import sys

# Complete the bonAppetit function below.
def bonAppetit(bill, k, b):
    equal_split = sum(bill)/2
    declined = bill.pop(k)
    actual_split= sum(bill)/2
    if b==actual_split:
        print('Bon Appetit')
    else:
        settle = int( math.fabs(actual_split-b))
        print('{}'.format(settle))


if __name__ == '__main__':
    nk = input().rstrip().split()

    n = int(nk[0])

    k = int(nk[1])

    bill = list(map(int, input().rstrip().split()))

    b = int(input().strip())

    bonAppetit(bill, k, b)
