#!/bin/python3

import math
import os
import random
import re
import sys



#
# Complete the 'dateandtime' function below.
#
# The function accepts INTEGER val as parameter.
# The return type must be LIST.
#
from datetime import datetime, date, time


def dateandtime(val,tup):
    # Write your code here
    l=[]
    weekdays=['Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday', 'Saturday', 'Sunday']
    months=['January', 'February', 'March', 'April', 'May', 'June', 'July', 'August', 'September', 'October', 'November', 'Dececmber']
    mondict={1:31, 2:28, 3:31, 4:30, 5:31, 6:30, 7:31, 8:31, 9:30, 10:31, 11:30, 12:31 }
    
    if(val ==1):
        dt=date(tup[0], tup[1], tup[2])
        l.append(dt)
        d=str(dt.day)
        m=str(dt.month)
        if dt.day <10:
           d='0'+str(dt.day)
        if dt.month <10:
           m='0'+str(dt.month) 
        l.append('{0}/{1}/{2}'.format(d, m, dt.year))
        
    elif val==2:
        
        timestamp = datetime.fromtimestamp(tup[0])
        l.append(datetime.date(timestamp))
    elif val==3:
        # print(val, tup)
        times=time(tup[0], tup[1], tup[2])
        l.append(times)
        h=str(times.hour-12)
        if(times.hour-12<10):
            h='0'+str(times.hour-12)
        times=time(int(h), times.minute, times.second)
        l.append(h)
        
    elif val==4:
        
        dt=date(tup[0], tup[1], tup[2])
        
        l.append(weekdays[dt.weekday()])
        # l.append(dt.weekday())
        l.append(months[dt.month-1])
        daynum=0
        for i in range(1, dt.month):
            daynum+=mondict[i]
        daynum+=dt.day
        if dt.year%4==0:
            daynum+=1
        d=str(daynum)
        if daynum<10:
            d='00'+str(daynum)
        elif daynum>=10 and daynum<100:
            d='0'+str(daynum)
        else:
            d=str(daynum)
        l.append(d)
        # l.append((val, tup))
    elif val==5:
        dt=datetime(year=tup[0], month=tup[1], day=tup[2], hour=tup[3], minute=tup[4], second=tup[5])
        
        l.append(dt)        
        
    return l

if __name__ == '__main__':
    val = int(input().strip())
    
    if val ==1 or val==4 or val ==3:
        qw1_count=3
    if val==2:
        qw1_count=1
    if val ==5:
        qw1_count=6
    qw1 = []

    for _ in range(qw1_count):
        qw1_item = int(input().strip())
        qw1.append(qw1_item)
        
    tup=tuple(qw1)
    
    ans = dateandtime(val,tup)
    
    print(ans)