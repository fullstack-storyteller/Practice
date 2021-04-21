def viralAdd(n):
    
    likers=0
    # shared_on_that_day=0
    # liked_on_that_day=0
    # for i in range(1, n+1):        
    #     if i==1:
    #         shared_on_that_day=5
    #         liked_on_that_day = 5//2
    #         likers+=liked_on_that_day
    #     else:
    #         shared_on_that_day = (liked_on_that_day*3)
    #         liked_on_that_day = shared_on_that_day//2
    #         likers+=liked_on_that_day
    # return likers    
    liked=0
    for i in range(1, n+1):
        if i==1:
            liked=5//2
        else:
            liked=(3*liked)//2
        likers+=liked
            #likers=likers+3*(likers//2)
    return likers
# print(viralAdd(1))
print(viralAdd(50))
# print(viralAdd(50))