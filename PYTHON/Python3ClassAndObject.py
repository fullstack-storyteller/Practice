#!/bin/python3

import math
import os
import random
import re
import sys



#
#Write your code here

class comp:
    def __init__(self, real, img):
        self.real=real
        self.img=img

    def add(self, addit):
        realsum=self.real+addit.real
        imgsum=self.img+addit.img
        sign=''
        if imgsum>=0:
            sign='+'
        print( 'Sum of the two Complex numbers :{0}{1}{2}i'.format(realsum,sign, imgsum))
    
    def sub(self, subit):
        realsub=self.real-subit.real
        imgsub=self.img-subit.img
        sign =''
        if imgsub>=0:
            sign='+'
        print( 'Subtraction of the two Complex numbers :{0}{1}{2}i'.format(realsub,sign, imgsub))

if __name__ == '__main__':
    
    real1 = int(input().strip())
    img1 = int(input().strip())
    
    real2 = int(input().strip())
    img2 = int(input().strip())
    
    p1 = comp(real1,img1)
    p2 = comp(real2,img2)

    p1.add(p2)
    p1.sub(p2)


# #!/bin/python3

# import math
# import os
# import random
# import re
# import sys

# class Movie:
#     def __init__( self, name, n, cost):
#         self.name=name
#         self.n=n
#         self.cost=cost
#     def __str__(self):
#         return 'Movie : {0}\nNumber of Tickets : {1}\nTotal Cost : {2}'.format(self.name, self.n, self.cost)

# # Write your code here

# if __name__ == '__main__':
#     name = input()
#     n = int(input().strip())
#     cost = int(input().strip())
    
#     p1 = Movie(name,n,cost)
#     print(p1)

