# a=[0, 0, 0, 0, 0, 0, 0, 0, 0, 0]
queries=[
    # [1, 5, 3],
    # [4, 8, 7],
    # [6, 9, 1]

    [1, 2, 100],
    [2, 5, 100],
    [3, 4, 100]
]

def arrayManipulation(n, queries):
    # a=[0 for _ in range(n)]
        
    # for q in queries:
    #     for i in range(q[0]-1, q[1]):
    #         a[i]+=q[2]
        
    # return max(a)
    a=[0]*(n)
    for q in queries:
        a[q[0]-1]+=q[2]
        print(a)
        if q[1]+1<=n:
            a[q[1]-1]-=q[2]
            print(a)
    print(a)
    maximum=0
    result=0
    for i in range(n):
        result+=a[i]
        if maximum<result:
            maximum=result
    
    # return a
    return maximum

print(arrayManipulation(5, queries))
# print(arrayManipulation(10, queries))