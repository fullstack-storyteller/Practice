def Merge(a, l, m, r):
    # print(a)
    #uncomment this and run to visualize
    leftArray=a[:m+1]
    rightArray=a[m+1:]
    i=0
    j=0
    k=0
    while i< len(leftArray) and j <len(rightArray):
        if leftArray[i]<rightArray[j]:
            a[k]=leftArray[i]
            i+=1
        else:
            a[k]=rightArray[j]
            j+=1
        k+=1
    while i< len(leftArray):
        a[k]=leftArray[i]
        i+=1
        k+=1

    while j< len(rightArray):
        a[k]=rightArray[j]
        j+=1
        k+=1
    
    # print(a)

def MergeSort(a, l, r):
    # Merge sort is a particular interesting example of divide and conquer method of solving problems    #
    #      
    #  Mechanism is as follows  
    #  first we keep breaking left array    
    #  untill its left side is equal to its right side or l<r is false    
    #  then we combine. Combining is bottom up process    #     
    # 
    #  #

    if l<r:
        middle=(l+r)//2 #make sure not to use the single slash sign, because it denotes decimal quptient
        # print(a[l: middle+1]) #uncomment this and run to visualize
        MergeSort(a, l, middle) #-> run the mergeSort for left sub array
        # print(a, middle+1, r+1) #uncomment this and run to visualize
        MergeSort(a, middle+1, r) # -> once left subarray is finished sorting, run merge sort for the right sub array
        Merge(a, l, middle, r)

s=[12, 34, 1, 45, 9009, 23, 12, 23, 123, 12]
l=0
r=len(s)-1
print(s)
MergeSort(s, l, r)
print(s)
