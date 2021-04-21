class A:

    @classmethod
    def getC(self):
        print('In Class A, method getC.')

class B(A):
    pass

b = B()
B.getC()
b.getC()