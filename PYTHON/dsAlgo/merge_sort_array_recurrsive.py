def merge_sort(list):
    '''
    Sort a list in ascending order
    Return a new sorted list (not sorting in in-place)
    
    Divide: Find the midpoint of the list and divide into sublists
    
    Conquer: Recurssively sort the sublists created in the previous step

    Combine: Merge the sorted sublists create in previous step

    takes overall O(nlogn) time
    takes overall O(n) space

    '''

    #base condition, if the list is having only one element or its empty, then it is already sorted
    if(len(list)<=1):
        return list

    # split the list
    left_half, right_half = split(list)

    left= merge_sort(left_half)
    right=merge_sort(right_half)

    return merge(left, right)

def split(list):
    '''
    divide the unsorted list at mid point into sublist

    return two sublist left and right

    takes overall O(logn) time
    takes overall O(1) space
    '''

    mid=len(list)//2
    return list[:mid], list[mid:]

def merge(left, right):
    '''
    merge the left and right lists sorting them in the process
    return a new list

    takes overall O(n) time
    takes pverall O(n) space 
    '''
    li=[]
    l=0 # index in left list
    r=0 # index in right list

    while(l<len(left) and r<len(right)):
        if left[l]<right[r]:
            li.append(left[l])
            l+=1
        else:
            li.append(right[r])
            r+=1
    while(l<len(left)):
        li.append(left[l])
        l+=1

    while(r<len(right)):
        li.append(right[r])
        r+=1

    return li

numbers=[17, 3, 7, 8, 10,2, 4, 5]

print(merge_sort(numbers))
