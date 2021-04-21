def migratoryBirds(arr):
    d={}
    print(d)
    for i in arr:
        if d=={}: # dictionary is empty
            d[i]=1 #insert 1st key value
        else:
            if (i in d.keys()):
                temp =d[i]
                d[i]=temp+1
            else:
                d[i]=1
    minimum=max(d.values())
    print(minimum)
    mylist=[]
    for i in d.keys():
        if d[i]==minimum:
            mylist.append(i)
    print(mylist)
    return min(mylist)

print(migratoryBirds([1, 4, 4, 4, 5, 3]))