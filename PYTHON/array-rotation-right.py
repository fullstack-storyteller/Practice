#!/bin/python3

import math
import os
import random
import re
import sys

# Complete the circularArrayRotation function below.

def circularArrayRotation(a, s, queries):
    l=len(a)
    result=[]
    for q in queries:
        temp=[]
        s%=l
        if s==0:
            s=l
        for i in range(l):
            if i==0:
                temp.append(a[l-s])
            else:
                temp.append(a[i-s])
        result.append(temp[q])

    return result


if __name__ == '__main__':
    # fptr = open(os.environ['OUTPUT_PATH'], 'w')

    nkq = [51, 51, 100]#input().split()

    n = int(nkq[0])

    k = int(nkq[1])

    q = int(nkq[2])

    # a = list(map(int, input().rstrip().split()))
    a=[39356, 87674, 16667, 54260, 43958, 70429, 53682, 6169, 87496, 66190, 90286, 4912, 44792, 65142, 36183, 43856, 77633, 38902, 1407, 88185, 80399, 72940, 97555, 23941, 96271, 49288, 27021, 32032, 75662, 69161, 33581, 15017, 56835, 66599, 69277, 17144, 37027, 39310, 23312, 24523, 5499, 13597, 45786, 66642, 95090, 98320, 26849, 72722, 37221, 28255, 60906]
    queries = [
        47,
10,
12,
13,
6,
29,
22,
17,
7,
3,
30,
45,
1,
21,
50,
17,
25,
42,
5,
6,
47,
2,
24,
1,
6,
14,
24,
43,
7,
2,
35,
3,
13,
22,
16,
19,
0,
12,
10,
32,
41,
14,
1,
42,
35,
0,
9,
34,
17,
14,
15,
38,
17,
13,
40,
48,
27,
38,
41,
8,
14,
25,
11,
27,
47,
2,
20,
22,
39,
4,
28,
29,
43,
29,
21,
1,
4,
4,
10,
46,
43,
50,
33,
34,
12,
47,
32,
13,
8,
47,
22,
23,
21,
33,
24,
43,
35,
19,
39,
24
    ]

    # for _ in range(q):
    #     queries_item = int(input())
    #     queries.append(queries_item)

    result = circularArrayRotation(a, k, queries)

    # fptr.write('\n'.join(map(str, result)))
    # fptr.write('\n')

    # fptr.close()

    print('\n'.join(map(str, result)))
    print('\n')

# def shiftArray(a, s , direction="Right"):
#     l=len(a)
#     s%=l#resolved the length of s to come into 0 to len(a)-1
#     temp=[]
#     for i in range(l):

#         if i==0:
#             temp.append(a[l-s])
#         else:
#             temp.append(a[i-s])
        

#         # print(temp)
#     return temp


# # array=[2,5,7,0,1,3,7]
# array = [1, 2, 3]
# shift = 2
# print([i for i in range(len(array))])
# print(array)
# print(shiftArray(array, shift ))