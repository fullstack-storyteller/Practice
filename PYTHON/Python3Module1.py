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
from datetime import date, time, datetime
def dateandtime(val,tup):
    # Write your code here
    myList=[]
    if val==1:
        dt=date(tup[0], tup[1], tup[2])
        myList.append(dt)
        myList.append('{0}/{1}/{2}'.format(dt.day, dt.month, dt.year))
    elif val==2:
        dt=datetime.date(datetime.fromtimestamp(tup[0]))
        myList.append(dt)

    elif val==3:
        tm=time(tup[0], tup[1], tup[2])
        myList.append(tm)
        #pending 00-12 format changing
		hr=str(tm.hour)
		if tm.hour ==0:
			hr='12'
		elif tm.hour <10:
			hr='0'+str(tm.hour)
		elif tm.hour>12:
			s=tm.hour-12
			if s<10:
				hr='0'+str(s)
			else:
				hr=str(s)
		myList.append(hr)	

    elif val==4:
        dt=date(tup[0], tup[1], tup[2])
        weekarr=['Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday', 'Saturday', 'Sunday']
        myList.append(weekarr[dt.weekday()])
        months=['January', 'February','March','April','May','June', 'July', 'August', 'September', 'October', 'November', 'December']
        myList.append(months[dt.month-1])

        #get day number of the year
        dayList={1:31, 3:31, 4:30, 5:31, 6:30, 7:31, 8:31, 9:30, 10:31, 11:30, 12:31}
        if(dt.year%4==0):
            dayList[2]=29
        else:
            dayList[2]=28
        dayCount=0
        # i=0
        for i in range(1, dt.month):
            dayCount=dayCount+ dayList[i]
        dayCount=dayCount+dt.day
        myList.append(dayCount)

    elif val==5:
        dt=datetime(tup[0],tup[1], tup[2], tup[3], tup[4], tup[5])
        myList.append(dt)
    return myList





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