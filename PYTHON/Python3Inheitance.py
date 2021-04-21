#!/bin/python3

import math
import os
import random
import re
import sys


# Write your code here
class rectangle:
      
    # area
    def area(self, Length, Breadth):
        area = Length*Breadth
        print("Area of Rectangle is ",area)
    # display
    def display(self):
        print("This is a Rectangle")

class square:
    def display(self):
        print("This is a Square")
    def area(self, Side):
        area=Side*Side
        print("Area of square is ",area)
if __name__ == '__main__':
    
    l = int(input())
    b = int(input())
    s = int(input())

    obj1 = rectangle()
    obj1.display()
    obj1.area(l,b)

    obj2 = square()
    obj2.display()
    obj2.area(s)


# #!/bin/python3

# import math
# import os
# import random
# import re
# import sys

# class parent:
#   def __init__(self,total_asset):
#     self.total_asset = total_asset

#   def display(self):
#     print("Total Asset Worth is "+str(self.total_asset)+" Million.")
#     print("Share of Parents is "+str(round(self.total_asset/2,2))+" Million.")

# # It is expected to create two child classes 'son' & 'daughter' for the above class 'parent'
# #
# #Write your code here
# class son(parent):
#     def __init__(self, total_asset, sp):
#         parent.__init__(self,total_asset)
#         self.sp=sp
#     def son_display(self):
#         son_amt=round(((self.total_asset*self.sp)/100),2)
#         print('Share of Son is {0} Million.'.format(son_amt))

# class daughter(parent):
#     def __init__(self, total_asset, dp):
#         super().__init__(total_asset)
#         self.dp=dp
#     def daughter_display(self):
#         d_amt=round(((self.total_asset*self.dp)/100),2)
#         print('Share of Daughter is {0} Million.'.format(d_amt))


# if __name__ == '__main__':
    
#     t = int(input())
#     sp = int(input())
#     dp = int(input())


#     obj1 = parent(t)
    

#     obj2 = son(t,sp)
#     obj2.son_display()
#     obj2.display()


#     obj3 = daughter(t,dp)
#     obj3.daughter_display()
#     obj3.display()
    
#     print(isinstance(obj2,parent))
#     print(isinstance(obj3,parent))

#     print(isinstance(obj3,son))
#     print(isinstance(obj2,daughter))