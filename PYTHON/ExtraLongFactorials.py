import math
def myfactorial(n):
    # return math.factorial(n)
    for i in range(n-1, 1, -1):
        n*=i
    return n

print("Factorial =",myfactorial(25))
print("Factorial =",math.factorial(100))