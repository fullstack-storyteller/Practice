import math
arr =[
# [1, 1, 1, 0, 0, 0],
# [0, 1, 0, 0, 0, 0],
# [1, 1, 1, 0, 0, 0],
# [0, 0, 2, 4, 4, 0],
# [0, 0, 0, 2, 0, 0],
# [0, 0, 1, 2, 4, 0]

# [-1, -1,  0, -9, -2, -2],
# [-2, -1, -6, -8, -2, -5],
# [-1, -1, -1, -2, -3, -4],
# [-1, -9, -2, -4, -4, -5],
# [-7, -3, -3, -2, -9, -9],
# [-1, -3, -1, -2, -4, -5]

[ 0, -4, -6,  0, -7, -6],
[-1, -2, -6, -8, -3, -1],
[-8, -4, -2, -8, -8, -6],
[-3, -1, -2, -5, -7, -4],
[-3, -5, -3, -6, -6, -6],
[-3, -6,  0, -8, -6, -7]
]
def hourglassSum(arr):
    hourglass_sum=-9999
    hourglass_dimension=3
    
    for down in range(len(arr)-2):#0
        for forward in range( len(arr)-2):#1
            # arr[0][0], arr[0][1], arr[0][2]
            #            arr[1][1],
            # arr[2][0], arr[2][1], arr[2][2]
            temp_sum=-9
            count=0
            for i in range(hourglass_dimension):#2
                temp_sum+=arr[down][forward+i]+arr[down+2][forward+i]#4
                print('down', down, 'forward', forward, 'count', count, 'temp_sum', temp_sum, 'hourglass_sum', hourglass_sum)
                count+=1#3
                if count ==3 :
                    temp_sum+=arr[down+1][forward+1]
                    print('down', down, 'forward', forward, 'count', count, 'temp_sum', temp_sum, 'hourglass_sum', hourglass_sum)
            if hourglass_sum<temp_sum:#int(math.fabs( temp_sum)):
                hourglass_sum= temp_sum #int(math.fabs( temp_sum))
    return hourglass_sum



print(hourglassSum(arr))
a = [4,2,1, 3]
print([a[i] for i in range(len(a)-1, -1, -1)])
# print(a[-1:])
# # print(arr)