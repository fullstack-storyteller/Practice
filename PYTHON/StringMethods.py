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

def stringmethod(para, special1, special2, list1, strfind):
    # Write your code here
    word1=''.join([i for i in para if i not in special1])

    # test=list(word1[:70])
    # test.reverse()
    
    rword2=''.join(word1[:71:-1])
    print(rword2)

    # temp_rword2=[i for i in list(rword2) if i!=' ']
    print(special2.join([i for i in rword2 if i!=' ']))

    

    if len([i for i in list1 if i not in para])==0:
        # print("Every string in", list1, "were present")
        print("Every string in {0} were present".format(list1))
    else:
        print("Every string in {0} were not present".format(list1))
        # print("Every string in", list1, "were not present")
    temp_word1=word1.split()
    print(temp_word1[:20])

    store={}
    for i in temp_word1:
        if i in store.keys():
            store[i]=store[i]+1
        else:
            store[i]=1
    less_used=[i for i in store.keys() if store[i]<3]
    # less_used.reverse()
    print(less_used[-20:])

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

# stringmethod('My Name is !anthony+gonsalves', '+~!', '!+', ['My', 'Manish', 'Kumar'], 'Manish')
# temp=[1, 3, 5, 2, 8, 9]
# print(temp[-3:])
# string ='Manish'
# if 'man' in string:
#     print('Yes')


# string1 ='Manish coo is cool!'
# temp1=list(string1)
# temp1.reverse()
# string1=''.join(temp1)
# print(string1)
# print(string1.find('coo' ))