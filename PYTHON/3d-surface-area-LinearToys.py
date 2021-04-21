# import math
# def surfaceArea():

def findOpenSurfaces(x):
    fromTopAndBottom=2*len(x)
    fromLateralSide=2*sum(x)
    leftToRight=x[0]
    rightToLeft=x[len(x)-1]

    for i in range(len(x)-1): # be very carefull with limits

        # moving left to right but counting the back side

        if x[i+1]-x[i] > 0:# and i+1<len(x):
            leftToRight+=x[i+1]-x[i]

        # moving left to right but counting the front side
        if x[i]-x[i+1]>0:# and i+1 < len(x):
            rightToLeft+= x[i]-x[i+1]
    
    return fromLateralSide+leftToRight+rightToLeft+fromTopAndBottom

        


print(findOpenSurfaces([1, 2, 2, 3, 1, 4, 5]))
