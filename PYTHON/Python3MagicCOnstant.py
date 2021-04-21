# import math
# import os
# import random
# import re
# import sys

def generator_Magic(n1):
    # Write your code here
    for i in range(3, n1+1):
        yield (i*(i*i+1))//2

# if __name__ == '__main__':

n = int(input().strip())
    
for i in generator_Magic(n):
    print(int(i))

gen1 = generator_Magic(n)
print(type(gen1))