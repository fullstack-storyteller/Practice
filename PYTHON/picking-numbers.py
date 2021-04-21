def pickingNumbers(a):
    # Write your code here
    d={}
    for i in a:
        if d=={} or i not in d.keys():
            d[i]=1
        else:
            temp=d[i]
            d[i]=temp+1
    # print('d =', d)
    # working with dictionary is really awesome.
    # this problem are unbreakable until I got a hint to use dictionary and
    # the idea that if each element will have a difference of <=1, then 
    # that particulat array will have only two distinct elements
    # one which will be having a difference of 0 other which will be having a difference of 1

    # if we were to talk about a difference <=2 the total distinct elements would be 3
    # one with 0 difference, 2nd with 1 difference and third with 2 difference. Remember this.
    largest=0
    
    for i in d.keys():
        if i+1 in d.keys():
            if largest<d[i]+d[i+1]:
                largest=d[i]+d[i+1]
            # print('came in 1st')
        else:
            if largest< d[i]:
                largest=d[i]
    return largest
print('pickingNumbers([1, 2, 2, 3, 1, 2])',pickingNumbers([1, 2, 2, 3, 1, 2]))
print('pickingNumbers([4, 6 ,5, 3, 3, 1])',pickingNumbers([4, 6 ,5, 3, 3, 1]))
print('pickingNumbers([1, 1 ,2, 2, 4, 4, 5, 5, 5])',pickingNumbers([1, 1 ,2, 2, 4, 4, 5, 5, 5]))
