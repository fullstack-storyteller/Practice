#!/bin/python3

import math
import os
import random
import re
import sys
magic_constant=15
#method runChecks
# def runChecks(matrix, diagonals, rows, columns, order):#n will be 3 as it is fixed
def checkDiagonals(matrix, order):
    diagonals=[]
    for k in [0, 2]:# because only 2 diagonals are possible
        if (k==0 and sum([matrix[i,i] for i in range(order)])!=15) or (k==2 and sum([matrix[i, order-i] for i in range(order)])!=15):
            diagonals.append(k)
    return diagonals
def checkRows(matrix, order):
    rows=[]
    for r in range(order): # rows = 0, 1, 2
        row_sum=0
        for c in range(order): #columns =0, 1, 2
            row_sum+=matrix[r, c]#summing rows
        if row_sum!=15:
            rows.append(r)
    return rows

def checkColumns(matrix, order):
    columns=[]
    for r in range(order): # rows = 0, 1, 2
        col_sum=0
        for c in range(order): #columns =0, 1, 2
            col_sum+=matrix[c, r] #summing columns
        if col_sum!=15:
            columns.append(r)
    return columns
    # row_col=set(rows).intersection(set(columns))
    # common =set(diagonals).intersection(row_col)

    # if len(common)==0 and len(row_col)==0:
    #     return ()# loop break condition because magic square is achieved
    # if list(common)==0 and len(row_col)!=0:
    #     return tuple(row_col)# diagonals fixed, but not rows and columns
    # else:
    #     return tuple(common) # diagonal needs fixing along with rows and columns


                    


# Complete the formingMagicSquare function below.
def formingMagicSquare(s):
    cost=[]
    # temp=runChecks(s, diagonal_faults, row_faults,column_faults, 3)
    while True:
        diagonal_faults=checkDiagonals(s, 3)
        row_faults=checkRows(s, 3)
        column_faults=checkColumns(s,3)
        for i in diagonal_faults:
            if i in row_faults and i in column_faults:
                fix(s, i, i, 3)

        
    return sum(cost)
def fix(matrix, row, col, order):
    
if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    s = []

    for _ in range(3):
        s.append(list(map(int, input().rstrip().split())))

    result = formingMagicSquare(s)

    fptr.write(str(result) + '\n')

    fptr.close()
