#!/bin/python3

import math
import os
import random
import re
import sys

def getdict(ar):
    d={}
    for i in ar:
        if d.__contains__(i):
            temp=d[i]
            d[i]=temp+1
        else: 
        #this will cover both end cases
        #1. if the dictionary is empty
        #2. if the dictionary is not empty but the key is new
            d[i]=1
    return d
# Complete the sockMerchant function below.
def sockMerchant(n, ar):
    d=getdict(ar)
    pair_counter=0
    for i in d.values():
        if(i>=2):
            pair_counter+=i//2
    return pair_counter

if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    n = int(input())

    ar = list(map(int, input().rstrip().split()))

    result = sockMerchant(n, ar)

    fptr.write(str(result) + '\n')

    fptr.close()
