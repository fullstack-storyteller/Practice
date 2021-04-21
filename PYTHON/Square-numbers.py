
import math

# def mySuareRoot(x):
#     for i in range(2, x):
#         if x%i==0 and x//i==i:
#             return i
#     else:
#         return -1

def squares(a, b):
    count=0
    a1=int(math.sqrt(a))
    
    b1=int(math.sqrt(b))+1
    
    for i in range(a1, b1+1 ):
        
        # if mySuareRoot(i)!=-1:
        temp=i*i
        if temp in range(a, b+1):
        # if isinstance( math.sqrt(i), int):
            count+=1
    

    return count


print('squares(3, 9)', squares(3, 9))
print('squares(17, 24)', squares(17, 24))
print('squares(4, 4)', squares(4, 4))

# print('System SQRT: ', math.sqrt(9))
# print('My SQRT: ', mySuareRoot(10))