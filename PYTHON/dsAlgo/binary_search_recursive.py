##
# Time Complexity: O(logn)
# Space Complexity: O(logn)
# #
def binary_search(list, target):
    if len(list) == 0:
        return False
    
    midpoint=len(list)//2
    if(list[midpoint]==target):
            return True
    else:
        if(list[midpoint]<target):
            return binary_search(list[midpoint+1:], target)
        else:
            return binary_search(list[ :midpoint], target) 
            # the last index midpoint won't be included
    

def verify (result):
    print('Target found: ', result)

numbers=[1, 3,4, 5, 8, 11, 12, 12]

verify(binary_search(numbers, 81))
verify(binary_search(numbers, 5))