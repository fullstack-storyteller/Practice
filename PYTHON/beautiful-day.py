#!/bin/python3

import math
import os
import random
import re
import sys

def rev_num(y):
    num=0
    if y in range(10):
        return y
    else:
        while y>0:
            num = num*10+y%10
            y=y//10
        return num

# Complete the beautifulDays function below.
def beautifulDays(i, j, k):
    beautiful_days=0
    for x in range(i, j+1):
        if int(math.fabs(x-rev_num(x)))%k==0:
            beautiful_days+=1
    return beautiful_days

print(beautifulDays(20, 23, 6))
