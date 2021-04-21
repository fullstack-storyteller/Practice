#!/bin/python3

import math
import os
import random
import re
import sys



#
# Complete the 'calen' function below.
#
# The function accepts TUPLE datetuple as parameter.
#

import calendar as c
import itertools as itr
def isleap(year):
    return year%4==0
def usingcalendar(datetuple):
    # Write your code here
    # print(datetuple) #(2020, 10, 11)
    month = datetuple[1]
    if(isleap(datetuple[0])):
        month=2
    print(c.month(datetuple[0], month))

    obj=c.Calendar()
    days=[d for d in obj.itermonthdates(datetuple[0], month)]
    print(days[-7:])

    ls=[d for d in obj.itermonthdays(datetuple[0], month)]

    weekdays=['Monday', 'Tuesday','Wednesday', 'Thursday', 'Friday', 'Saturday', 'Sunday']
    reset_weekdays=[]
    for i in range(7):
        reset_weekdays.append(weekdays[c.weekday(datetuple[0], month, i+1)])

    dc={}

    for i in reset_weekdays:
        if i=='Saturday':
            dc[i]=len([x for x in ls[5::7] if x!=0])
        if i=='Sunday':
            dc[i]=len([x for x in ls[6::7] if x!=0])
        if i=='Monday':
            dc[i]=len([x for x in ls[0::7] if x!=0])
        if i=='Tuesday':
            dc[i]=len([x for x in ls[1::7] if x!=0])
        if i=='Wednesday':
            dc[i]=len([x for x in ls[2::7] if x!=0])
        if i=='Thursday':
            dc[i]=len([x for x in ls[3::7] if x!=0])
        if i=='Friday':
            dc[i]=len([x for x in ls[4::7] if x!=0])
    
    
    maxday=0
    ans=''
    for i in dc.keys():
        if dc[i]>maxday:
            ans=i
            maxday=dc[i]
    print(ans)


if __name__ == '__main__':
    qw1 = []

    for _ in range(3):
        qw1_item = int(input().strip())
        qw1.append(qw1_item)
        
    tup=tuple(qw1)

    usingcalendar(tup)


# import itertools as itr
# import calendar as c

# d=(2020, 2, 10)

# print(c.month(d[0], d[1]))
# # print(c.weekheader(9))
# weekdays=['Monday', 'Tuesday','Wednesday', 'Thursday', 'Friday', 'Saturday', 'Sunday']

# print(weekdays[c.weekday(d[0],d[1], 1)])
# cl=c.Calendar()
# ls=[i for i in cl.itermonthdays(d[0], d[1])]
# # print(ls)

# reset_weekdays=[]
# for i in range(7):
#     reset_weekdays.append(weekdays[c.weekday(d[0],d[1], i+1)])

# # print(reset_weekdays)

# dc={}

# for i in reset_weekdays:
#     if i=='Saturday':
#         dc[i]=len([x for x in ls[5::7] if x!=0])
#     if i=='Sunday':
#         dc[i]=len([x for x in ls[6::7] if x!=0])
#     if i=='Monday':
#         dc[i]=len([x for x in ls[0::7] if x!=0])
#     if i=='Tuesday':
#         dc[i]=len([x for x in ls[1::7] if x!=0])
#     if i=='Wednesday':
#         dc[i]=len([x for x in ls[2::7] if x!=0])
#     if i=='Thursday':
#         dc[i]=len([x for x in ls[3::7] if x!=0])
#     if i=='Friday':
#         dc[i]=len([x for x in ls[4::7] if x!=0])
# print(dc)

# mx=0
# answer=''
# for i in dc.keys():
#     if dc[i]>mx:
#         mx=dc[i]
#         answer=i
# print(answer)