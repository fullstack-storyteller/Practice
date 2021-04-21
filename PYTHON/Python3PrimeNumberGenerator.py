#!/bin/python3

import math
import os
import random
import re
import sys



#
# Complete the 'primegenerator' function below.
#
# The function is expected to return an INTEGER.
# The function accepts following parameters:
#  1. INTEGER num
#  2. INTEGER val
#

def primegenerator(num, val):
    order=0
    for i in range(2, num+1):
        if i==2:
            order =order+1
            if order %2==val:
                yield i
        else:
            isPrime=True
            for j in range(2, i):
                if i%j==0:
                    isPrime=False
                    break
            if(isPrime):
                order = order+1
                if order%2==val:
                    yield i

if __name__ == '__main__':

    num = int(input().strip())

    val = int(input().strip())

    for i in primegenerator(num, val):
        print(i,end=" ")