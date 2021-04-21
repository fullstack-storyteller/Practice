name = input("Please enter your name: ")
# Age = int(input("Please enter your age: "))
Age = float(input("Please enter your age: "))

print(f'My name is {name}!') # this works with python 3.6 or higher

#the below three work with Python 2 or 3
# print('My age is %s'% Age) #this is also working 
print('My age is %d'% Age) #this is also working
# print('My age is %f'% Age)#this is also working


print('My name is %s and my age is %d'% (name, Age ))
print(f"Hey, buddy my name is {name} and I'm {Age} years old")


test = ["Hello", 1, 4, 5.4]
print(test[0][1])