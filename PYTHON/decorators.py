def decorator_func(func):
    def wrapper(*args, **kwdargs):
        return func(*args, **kwdargs)
    wrapper.__name__ = func.__name__
    return wrapper


@decorator_func
def square(x):
    return x**2

print(square.__name__)
#################################################
# def bind(func):
#     func.data = 9
#     return func

# @bind
# def add(x, y):
#     return x + y

# print(add(3, 10))
# print(add.data)


def star(func): 
    def inner(args, **kwargs): 
        print("" * 3) 
        func(args, **kwargs) 
        print("" * 3) 
        return inner

def percent(func): 
    def inner(*args, **kwargs): 
        print("%" * 3) 
        func(*args, **kwargs) 
        print("%" * 3) 
        return inner

@star 
@percent 
def printer(msg): 
    print(msg) 
    printer("Hello")