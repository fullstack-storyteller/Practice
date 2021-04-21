def reveresing_num(x):
    number =0
    if x in range(10):
        return x
    else:
        # temp = x
        while x >0:
            number= 10*number + x%10
            x=x//10# since in the end, it will become 0.something which when converted to int becomes zero.
            # print(x)
        return number

num =int(input("Enter number to reverse: "))

print('You entered', num)

rev_num=reveresing_num(num)

print(num, 'reversed is', rev_num)

