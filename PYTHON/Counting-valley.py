# s='ududdduu'
# step_stack=list('l')
# print(step_stack)    
# step_stack.extend(s)
# print(step_stack)

#!/bin/python3

# import math
import os
# import random
# import re
# import sys

#this is equivalent to peek method
def last_item(t):
    return t[len(t)-1]#equivalent to peek the top element

# Complete the countingValleys function below.
def countingValleys(n, s):
    step_stack = list('l')
    valley_count=0
    for char in s:
        if len( step_stack) ==1 or last_item(step_stack)==char:
            step_stack.append(char)# equivalent to push() in stach
        else:
            if(step_stack.pop()=='D' and last_item(step_stack)=='l'): #pop the last element
                valley_count+=1
    return valley_count

if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    n = int(input())

    s = input()

    result = countingValleys(n, s)

    fptr.write(str(result) + '\n')

    fptr.close()
