def testing(**kwargs):#keyword argument in infinite number
    return kwargs#returns a dictionary

print(testing(test=1, string= "test", floater=23.6)) #dictionary


def foo(*args):
    return [a.upper() for a in args]

print(foo('ddd','aaa', 'bbb')) #default order of display
print(sorted(foo('ddd','aaa', 'bbb')))

print(10, 12, 13) # this can take any number of items/argument
print(sorted([81,10, 12, 13]))#Sorted sorts in asencding order
#to define methods/functions which takes  infinites number of arguments
def infinte(*args):
    return args #returns a tuple
print(infinte(9,8,7, 'steer')) #infinte will return a tuple



def avg(*args):
    return sum(args)/len(args)
print(avg(1, 3, 4, 7, 10))

def summed(*args):
    return sum(args)
print(summed(10, 23,45))


def area(length, breadth):#length, breadth here are callled parameters
    return length*breadth

print(area(4, 5))#non keyword argument
print(area(breadth=3, length=6))# keywork argument; position of argument doesn't matter here

# def perimeter(l=3, b): # this is wrong because default argument should be last, it should follwo non default argument 
def perimeter(l, b=6):# this is right
    return l*b
print(perimeter(4))
print(perimeter(4, 7))