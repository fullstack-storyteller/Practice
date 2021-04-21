myList=[12, 13.1, 24.7,9, 11.4]
print(myList)
print(myList[:2])
# number at index 2 will not be shown, but if it has nothing listed as destination index
# everything will be shown 
print(myList[2:4])

print(myList[-1])

# Python supports negative indexing
# it starts from the right with index = -1 then goes on.
# the slicing can applied on it similar to the positive indexing
print(myList[-2: -5]) #this is returning empty list as we trying to read higer value first
print(myList[-5:-2])