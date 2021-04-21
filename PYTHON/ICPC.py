
# def bitwise(x, y):
#     return int(x)|int(y)
def myBitwiseOR(x, y):
    # the below conversion is the best
    # converts bit in string to int in constant time then does the bitwise or in the operand
    return bin(int(x,2) | int(y,2)).count("1")
    # working
    # l= len(x)
    # p=list(map(bitwise, x, y))

    # working
    # for i in range(l):
    #     p.append(int(x[i]) | int(y[i]))
    # return p.count(1)


def acmTeam(topic):
    d=[]
    
    for i in range(len(topic)):
        for j in range(i+1, len( topic)):
    # d[i+1] = len([1 for x in topic[1] if x==1])
    # now d has student and the count of topics they know
            # if i!=j:
            # temp=[]
            # temp.append(i+1)
            # temp.append(j+1)
            # temp.append(myBitwiseOR(topic[i], topic[j]))
            d.append(myBitwiseOR(topic[i], topic[j]))
    # return d
    maxSubject=max(d)
    
    # for i in d:
    #     if i[2]>maxSubject:
    #         maxSubject=i[2]
    
    # print(maxSubject)
    # y=len([1 for i in d if i==maxSubject])
    y=d.count(maxSubject)
    # print(y)
    result =[]
    result.append(maxSubject)
    result.append(y)
    return result












topic=['10101',
'11100',
'11010',
'00101']
# topic=[ [1,0,1,0,1],
#         [1,1,1,0,0],
#         [1,1,0,1,0],
#         [0,0,1,0,1]]
print('\n'.join(map(str, acmTeam(topic))))
# s=''
# for i in range(1, 134):
#     s+='{}'.format(i)
# print(s)