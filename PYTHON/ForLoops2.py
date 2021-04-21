def write_numbers(num):
    # for i in range(0, num):# 10 is not included when going from 0 to 10
    # for i in range(num):#the start index defailts to 0, so does the step=1
    # for i in range(num, 2):#when you need to give the step explicitly, make sure to specifiy start index to otherwise, result might be abiguous
    for i in range(0, num, 2):
        print(i)

write_numbers(10)