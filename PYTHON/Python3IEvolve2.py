print('2'==2)
print([x*y for x, y in zip([3,4],[5,6])])

class A:
    def __init__(self):
        print('one')

    def f(self):
        print(float())
        print(hex(-255))

class B(A):
    def __init__(self):
        print('two')

    def f(self):
        print(float())
        print(hex(-42))

x = B()
x.f()

# class A:
#     def __init__(self, a = 5):
#         self.a = a

#         def f1(self):
#             self.a += 10


# class B(A):
#     def __init__(self, b = 0):
#         A.__init__(self, 4)
#         self.b = b

#     def f1(self):
#         self.b += 10

# x = B()
# x.f1()
# print(x.a,'-', x.b)


# class grandpa(object):
#     pass

# class father(grandpa):
#     pass

# class mother(object):
#     pass

# class child(mother, father):
#     pass

# print(child.__mro__)


# class A:
#     x = 0

#     def __init__(self, a, b):
#         self.a = a
#         self.b = b
#         A.x += 1

#     def __init__(self):
#         A.x += 1

#     def displayCount(self):
#         print('Count : %d' % A.x)

#     def display(self):
#         print('a :', self.a, ' b :', self.b)

# a1 = A('George', 25000)
# a2 = A('John', 30000)
# a3 = A()
# a1.display()
# a2.display()
# print(A.x)