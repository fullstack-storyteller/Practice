arr=[3, 3, 2, 1, 3]

def equalizeArray(arr):
    d={}
    
    for i in arr:
        if d=={} or i not in d.keys():
            d[i]=1
        else:
            d[i]+=1
    return len(arr)-max(d.values())
    

print(equalizeArray(arr))