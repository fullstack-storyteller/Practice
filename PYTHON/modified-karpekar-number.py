#!/bin/python3

import math
import os
import random
import re
import sys

# Complete the kaprekarNumbers function below.
def kaprekarNumbers(p, q):
    result=[]
    for j in range(p, q+1):
        temp=j**2
        lenVar=len(str(j))
        lenTemp=len(str(temp))
        digits=[]
    
        while temp>0:
            digits.append(temp%10)
            temp//=10
        digits.reverse()
        # print(lenVar, lenTemp)
        num2=0
        for i  in range(lenTemp-lenVar, lenTemp):
            num2= num2*10 + digits[i]
        
        num1=0
        for i in range(0, lenTemp-lenVar):
            num1= num1*10+ digits[i]

        # print(num1, num2)
        if num1+num2==j:
            result.append(j)
        
            # print( j)
    if result==[]:
        print( "INVALID RANGE")
    else:
        print( ' '.join(map(str, result)))

if __name__ == '__main__':
    p = int(input())

    q = int(input())

    kaprekarNumbers(p, q)
