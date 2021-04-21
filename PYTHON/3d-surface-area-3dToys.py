



#assumption is at least one cube will be there on the designated plane of HxW
# def findOpenSurfaces(x):
#     fromTopAndBottom=2*len(x)
#     fromLateralSide=2*sum(x)
    
#     leftToRight=x[0]
#     rightToLeft=x[len(x)-1]

#     for i in range(len(x)-1): # be very carefull with limits

#         # moving left to right but counting the back side

#         if x[i+1]-x[i] > 0:# and i+1<len(x):
#             leftToRight+=x[i+1]-x[i]

#         # moving left to right but counting the front side
#         if x[i]-x[i+1]>0:# and i+1 < len(x):
#             rightToLeft+= x[i]-x[i+1]
    
#     return fromLateralSide+leftToRight+rightToLeft+fromTopAndBottom



def surfaceArea(x, H, W):# Assuming two dimensional arrays only come

    fromTopToBottom =2*H*W
    # print('fromTopToBottom',fromTopToBottom)
    # if W==1:
    #     # this is a case of one dimension toy
    #     return findOpenSurfaces(x)

    leftSide= sum([ x[i][0] for i in range(H) ])
    # print('leftSide', leftSide )
    rightSide= sum([ x[i][W-1] for i in range(H) ])
    # print('rightSide', rightSide)
    
    lateralTopSide=sum([ x[0][i] for i in range(W)])
    # print('lateralTopSide', lateralTopSide)
    
    lateralBottomSide=sum([x[H-1][i] for i in range(W)])
    # print('lateralBottomSide', lateralBottomSide)

    leftToRight=0
    rightToLeft=0
    lateralTopToBottom=0
    lateralBottomToTop=0
                    # lateral top side
                # [1, 3, 4],|-----W
# left side     # [2, 2, 3],|       #right side
                # [1, 2, 4] |H
                    # lateral bottom side

    for j in range(H):#why not w-1, because we need to traverse all rows
        for i in range(W-1):# why? because we need to not go to last column

            # moving left to right but counting the back side
            if x[j][i+1]-x[j][i] > 0: #and i+1< len(x):
                leftToRight+=x[j][i+1]-x[j][i]

            # moving left to right but counting the front side
            if x[j][i]-x[j][i+1]>0 : #and i+1 < len(x):
                rightToLeft+= x[j][i]-x[j][i+1]
    
    # print('rightToLeft',rightToLeft, 'leftToRight',leftToRight)
    
                    # lateral top side
                # [1, 3, 4],|-----W
# left side     # [2, 2, 3],|       #right side
                # [1, 2, 4] |H
                    # lateral bottom side
    
    for i in range(W):#why not h-1, because we need to traverse all columns    
        for j in range(H-1):# why? because we need to not go to last row

            # moving lateral top to lateral bottom but counting the back side
            if x[j+1][i]-x[j][i] > 0: #and i+1< len(x):
                lateralTopToBottom+=x[j+1][i]-x[j][i]

            # moving lateral top to lateral bottom but counting the front side
            if x[j][i]-x[j+1][i]>0 : #and i+1 < len(x):
                lateralBottomToTop+= x[j][i]-x[j+1][i]

    # print('lateralTopToBottom', lateralTopToBottom, 'lateralBottomToTop', lateralBottomToTop)
    return fromTopToBottom+(leftSide+leftToRight+rightToLeft+rightSide) +( lateralTopSide+lateralTopToBottom+lateralBottomToTop+lateralBottomSide)


# A =[
#     [1, 3, 4],
#     [2, 2, 3],
#     [1, 2, 4]
#     ]
# print('surfaceArea(A, 3, 3)',surfaceArea(A, 3, 3))

# A=[51, 32, 28, 49, 28, 21, 98, 56, 99, 77]
# print('surfaceArea(A, 10, 1)',surfaceArea(A, 10, 1))

# A=[[3], [1], [2]]
# print('surfaceArea(A, 1, 3)',surfaceArea(A, 1, 3))

# A=[1]
# print('surfaceArea(A, 1, 1)',surfaceArea(A, 1, 1))

HW = input().split()

H = int(HW[0])

W = int(HW[1])

A = []

for _ in range(H):
    A.append(list(map(int, input().rstrip().split())))
print(A)    
print(surfaceArea(A, H, W))
