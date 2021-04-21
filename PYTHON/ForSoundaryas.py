def outer(x, y):

    def inner1():
        return x+y

    def inner2(z):
        return inner1() + z

    return inner2


f = outer(10, 25)

print(f(15))

# class A:

#     @classmethod
#     def getC(self):
#         print('In Class A, method getC.')

# class B(A):
#     pass

# b = B()
# B.getC()
# b.getC()

# def stringParser():
#     while True:
#         name = yield
#         (fname, lname) = name.split()
#         f.send(fname)
#         f.send(lname)

# def stringLength():
#     while True:
#         string = yield
#         print("Length of '{}' : {}".format(string, len(string)))


# f = stringLength(); next(f)

# s = stringParser()
# next(s)
# s.send('Jack Black')

# import re
# print(re.sub(r'[aeiou]', 'X', 'abcdefghij'))


# def s1(x, y):
#     return x*y

# class A:

#     @staticmethod
#     def s1(x, y):
#         return x + y

#     def s2(self, x, y):
#         return s1(x, y)

# a = A()
# print(a.s2(3, 7))
# def outer(x, y):

#     def inner1():
#         return x+y

#     def inner2():
#         return x*y

#     return (inner1, inner2)


# (f1, f2) = outer(10, 25)

# print(f1())
# print(f2())

# def stringDisplay():
#     while True:
#         s = yield
#         print(s*3)


# c = stringDisplay()
# next(c)
# c.send('Hi!!')


# class A:

#     def __init__(self, val):
#         self.x = val

#     @property
#     def x(self):
#         return self.__x

#     @x.setter
#     def x(self, val):
#         self.__x = val
        
#     @x.deleter
#     def x(self):
#         del self.__x

# a = A(7)
# del a.x
# print(a.x)
# class A:

#     def __init__(self, value):
#         self.x = value

#     @property
#     def x(self):
#         return self.__x

#     @x.setter
#     def x(self, value):
#         if not isinstance(value, (int, float)):
#             raise ValueError('Only Int or float is allowed')
#         self.__x = value

# a = A(7)
# a.x = 'George'
# print(a.x)

# def nameFeeder():
#     while True:
#         fname = yield
#         print('First Name:', fname)
#         lname = yield
#         print('Last Name:', lname)

# n = nameFeeder()
# next(n)
# n.send('George')
# n.send('Williams')
# n.send('John')

# def stringDisplay():
#     while True:
#         s = yield
#         print(s*3)


# c = stringDisplay()
# next(c)
# c.send('Hi!!')

# def stringParser():
#     while True:
#         name = yield
#         (fname, lname) = name.split()
#         f.send(fname)
#         f.send(lname)

# def stringLength():
#     while True:
#         string = yield
#         print("Length of '{}' : {}".format(string, len(string)))


# f = stringLength(); next(f)

# s = stringParser()
# next(s)
# s.send('Jack Black')

# from abc import ABC, abstractmethod

# class A(ABC):

#     @abstractmethod
#     @classmethod
#     def m1(self):
#         print('In class A, Method m1.')

# class B(A):

#     @classmethod
#     def m1(self):
#         print('In class B, Method m1.')

# b = B()
# b.m1()
# B.m1()
# A.m1()
# from abc import ABC, abstractmethod

# class A(ABC):
    
#     @abstractmethod
#     def m1():
#         print('In class A, Method m1.')

#     def m2():
#         print('In class A, Method m2.')

# class B(A):

#     def m2():
#         print('In class B, Method m2.')

# b = B()
# b.m2()



# from abc import ABC, abstractmethod

# class A(ABC):
#     @abstractmethod
#     def m1():
#         print('In class A.')

# a = A()
# a.m1()


# from abc import ABC, abstractmethod

# class A(ABC):

#     @abstractmethod
#     def m1(self):
#         print('In class A, Method m1.')

# class B(A):

#     def m1(self):
#         print('In class B, Method m1.')

# class C(B):

#     def m2(self):
#         print('In class C, Method m2.')

# c = C()
# c.m1()
# c.m2()