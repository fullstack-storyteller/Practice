# clouds = [0, 1, 0, 0, 0, 1, 0]
# clouds = [0,  0, 0, 0, 1, 0]
clouds = [0,  0, 1, 0, 0, 1, 0]

def isLowJumpPossible(c, position):
    if position +1 <len(c) and c[position+1]==0:
        return True
    return False

def isHighJumpPossible(c, position):
    if position+2< len(c) and c[position+2]==0:
        return True
    return False

def jumpingClouds(c):
    start=0
    count=0
    while start in range(len(c)):# range(7)-> 0, 6
        if isHighJumpPossible(c, start):
            start+=2
        elif isLowJumpPossible(c, start):
            start+=1
        else:
            break
        count+=1
    return count
print(jumpingClouds(clouds))

