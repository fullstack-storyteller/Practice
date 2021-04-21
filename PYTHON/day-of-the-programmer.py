#!/bin/python3

import os
#define isleap() method

def isleap(year):
    if year in range(1700, 1917) and year % 4==0:
        # the range can be upto 1917 but we need to write the case of 1918 seprately
        #so I just avoided it
        #but it turn out we don't even have to worry about 1918, so removing it
        return True
    elif year in range(1919, 2700) and ((year % 400==0) or (year% 4==0 and year%100!=0)):
        return True
    else:
        return False


# Complete the dayOfProgrammer function below.
def dayOfProgrammer(year):
    #day = 41 - feb
    if year ==1918:
        febr =15
    else:
        if isleap(year):
            febr=29
        else:
            febr=28
    day=41-febr
    return '{}.09.{}'.format(day, year)

if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    year = int(input().strip())

    result = dayOfProgrammer(year)

    fptr.write(result + '\n')

    fptr.close()

# print(isleap(2016))