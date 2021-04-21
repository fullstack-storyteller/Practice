#!/bin/python3

import math
import os
import random
import re
import sys



#
# Complete the 'FORLoop' function below.
#

def FORLoop():
    # Write your code here
    n=int(input())
    l1=[]
    for _ in range(n):
        l1.append(int(input()))
    print(l1)

    iter1=iter(l1)

    try:
        while True:
            print(next(iter1))
    except:
        raise StopIteration
    finally:
        return iter1



if __name__ == '__main__':
    try:
        d = FORLoop()
        print(type(d))
        print(next(d))
  
    except StopIteration:
        print('Stop Iteration : No Next Element to fetch')