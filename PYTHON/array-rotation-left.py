a=[1, 2, 3, 4, 5]
print([i for i in range(len(a))])
print(a)
temp=a[0]
def arrayRotationLeft(a, d):
    l=len(a)
    d%=l
    
    result=[]
    for i in range(l):
        if i+d == l:
            result.append(a[0])
        else:
            result.append(a[(i+d)%l])

    return result
    # numOfTimes=d
    # for _ in range(numOfTimes):
    #     temp=a[0]
    #     for i in range(l-1):
    #         a[i]=a[i+1]
    #     a[l-1]=temp
    

    # return a
print(arrayRotationLeft(a, 3))