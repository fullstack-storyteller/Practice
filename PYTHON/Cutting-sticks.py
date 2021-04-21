def myMinimum(a):
    #this method will return an element
    # which is minimum but not zero
    
    #in case of all element being zero, it will help terminate the loop
    mini = min(a)
    if mini != 0:
        return mini
    else:
        myarr= [i for i in a if i> mini]
        if len(myarr)==0:
            return 0
        else:
            return min(myarr)
    
    
            


# Complete the cutTheSticks function below.
def cutTheSticks(arr):
    l=len(arr)
    result=[]
    mini = myMinimum(arr)
    while mini != 0:
        count=0    
        for i in range(l):
            if arr[i]>=mini:
                arr[i]-=mini
                count+=1
        result.append(count)
        mini=myMinimum(arr)
    return result

print(cutTheSticks([5, 4, 4, 2, 2, 8]))