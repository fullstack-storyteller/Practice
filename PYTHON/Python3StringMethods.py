#!/bin/python3

import math
import os
import random
import re
import sys



#
# Complete the 'strmethod' function below.
#
# The function accepts following parameters:
#  1. STRING para
#  2. STRING spch1
#  3. STRING spch2
#  4. LIST li1
#  5. STRING strf
#
def returnFirstN(string, n):
    return string[:n]

def reverseStr(word):
    string=''
    for i in returnFirstN(word, 70):
        string= i+string
    return string

def stringmethod(para, special1, special2, list1, strfind):
    # Write your code here
    word1=para
    for i in special1:
        word1=word1.replace(i, '')
    # print(word1)

    rword2=reverseStr(word1)
    print(rword2)

    print(special2.join(rword2.replace(' ','')))

    flag=False

    for i in list1:
        if i not in para:
            flag=True
            break

    if flag:
        print('Every string in ',list1,'were not present')
    else:
        print('Every string in ',list1,'were present')
    
    print(returnFirstN(word1.split(), 20))

    d={}
    for i in word1.split():
        if i in d.keys():
            d[i]=d[i]+1
        else:
            d[i]=1
    words=[ i for i in d.keys() if d[i]<3]
    print(words[-20:])


    print(word1.rfind(strfind))
    


if __name__ == '__main__':
    para = input()

    spch1 = input()

    spch2 = input()
    
    qw1_count = int(input().strip())

    qw1 = []

    for _ in range(qw1_count):
        qw1_item = input()
        qw1.append(qw1_item)

    strf = input()

    stringmethod(para, spch1, spch2, qw1, strf)
