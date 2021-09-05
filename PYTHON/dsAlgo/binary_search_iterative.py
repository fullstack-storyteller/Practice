##
# Time Complexity: O(logn)
# Space Complexity: O(1)
# #

def binary_search( list, target):
    firstIndex = 0
    lastIndex = len(list)-1

    while firstIndex <= lastIndex:
        midpoint = (firstIndex+lastIndex) // 2 # floor division
        if list[midpoint]==target:
            return midpoint
        elif list[midpoint]<target:
            firstIndex=midpoint+1
        else :
            lastIndex=midpoint-1
    
    return None

def verify (index):
    if index is not None:
        print('Target found at ', index)
    else:
        print('Target not found')

numbers=[1, 3,4, 5, 8, 12, 14]
verify(binary_search(numbers, 12))