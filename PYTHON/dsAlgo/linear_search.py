# print('hello world!')
##
# Time Complexity: O(n)
# Space Complexity: O(1)
# #
def linear_search(list, target):
    """
    Returns the index position of the target if found, else return None
    """
    for i in range(0, len(list)):
        if list[i] == target:
            return i
    return None

def verify(index):
    if index is not None:
        print('Target found at index: ', index)
    else:
        print('Target not found in list')

numbers=[1, 2,3,4,3 ,5,7,6,9]

verify(linear_search(numbers, 3))