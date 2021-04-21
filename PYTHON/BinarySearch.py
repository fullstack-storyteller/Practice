def BinarySearch(myarr, findme, left, right):
    # left=0
    # right=len(myarr)-1
    #the reason why we should not define left or right here is,
    # everytime a binary search is called the value of right and left will vary
    # thus we should make sure, they are part of method parameters in the first place, especially if the code is working recursively.
    #in future we will try and see 
    if left <=right:
        mid=int((left+right)/2)#careful the mid must always be integer
        if myarr[mid]==findme:
            return mid
        if myarr[mid]<findme:
            return BinarySearch(myarr,findme,mid+1, right)
        if myarr[mid]>findme:
            return BinarySearch(myarr, findme, left, mid-1)
    return -1


#given a sorted array
#in python, my understanding is array=tuple, as they are fixed and immutable
myarr=(2, 3, 7, 11, 34, 56, 100, 121, 345,349, 711, 711, 711, 893, 910)
print('Current sorted array = ', myarr)
findme=int(input("Please enter the number to search: "))#make sure the user input is changed to integer
#anything a user enters is a string
result=BinarySearch(myarr, findme, 0, len(myarr)-1)
if result==-1:
    print('The item {} was not found!'.format(findme))
else:
    print('The item %d was found at %d'%(findme,result ))