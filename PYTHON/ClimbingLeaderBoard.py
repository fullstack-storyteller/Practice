
#the below code works fine for binary way for finding the interval but we need to optimize further
# so that, the test cases 6, 7, 8 and 9 for this question on hackerrank pass.
#---------------------------------------------------------------------------------------------------------------------------------
# def find_rank(lb, x):
#     l=0
#     r=len(lb)-1
    
#     while l<=r:
#         mid=(l+r)//2
#         if x>=lb[mid] and lb[mid-1]>x and mid-1>=0:
#             return mid+1
#         else:
#             # 100, 90, 80, 75, 60
#             # 50
                        
#             if(x>=lb[mid-1]):
#                 r=mid
#             if x<lb[mid]:
#                 l=mid+1
#     else:
#         return -1



# # get dense rank of leaderboard
# def denseRank(scores):
#     p=[]
#     print(scores)
#     for i in scores:
#         if p==[] or i not in p:
#             p.append(i)
    
#     return p
# # Complete the climbingLeaderboard function below.
# def climbingLeaderboard(scores , alice):
#     denseLB=denseRank(scores)
#     alice_rank=[]
#     for i in alice:
        
#         if i >=denseLB[0]:
#             alice_rank.append(1)
#         elif i < denseLB[len(denseLB)-1]:
#             alice_rank.append(len(denseLB)+1)
#         else:
#             #since all the arrays are sorted we can use binary search to find our required items
#             alice_rank.append( find_rank(denseLB, i))
#     return alice_rank
#---------------------------------------------------------------------------------------------------------------------------------
pre_calculated={}
def find_rank(lb, x, l, r):
    # when the leaderboard is reversed

    if x in pre_calculated.keys():
        return pre_calculated[x]
    else:
        while l<=r:
            mid=(l+r)//2
            if x>=lb[mid] and lb[mid+1]>x and mid+1<len(lb):
            # if x>=lb[mid] and lb[mid-1]>x and mid-1>=0:
                if  x not in pre_calculated.keys():
                    pre_calculated[x]=len(lb)-mid
                return len(lb)-mid
                
            else:
            
            # 60, 75, 80, 90, 100
            # 80 # - 3
            # 77 # - 4
            # 82 # - 3
            # 95 # - 2
                if(x<lb[mid]):
                    r=mid
                if x>=lb[mid]:
                    l=mid
                # if(x>=lb[mid-1]):
                #     r=mid
                # if x<lb[mid]:
                #     l=mid+1
    # l=0
    # r=len(lb)-1
    # when the leaderboard is as given in input
    # if x in pre_calculated.keys():
    #     return pre_calculated[x]
    # else:
    #     while l<=r:
    #         mid=(l+r)//2
    #         if x>=lb[mid] and lb[mid-1]>x and mid-1>=0:
    #             if  x not in pre_calculated.keys():
    #                 pre_calculated[x]=mid+1
    #             return mid+1
    #         else:
    #         # 100, 90, 80, 75, 60
    #         # 60, 75, 80, 90, 100
    #         # 70
    #             if(x>=lb[mid-1]):
    #                 r=mid
    #             if x<lb[mid]:
    #                 l=mid+1
    # else:
    #     return -1



# get dense rank of leaderboard
def denseRank(scores):

    p=[]
    for i in scores:
        if p==[] or i not in p:
            p.append(i)
    p.reverse()#reverse the dense-ranked leaderboard
    return p
    # return list(set(scores))
# Complete the climbingLeaderboard function below.
def climbingLeaderboard(scores , alice):
    denseLB=denseRank(scores)
    # alice.reverse()
    alice_rank=[]
    for i in alice:
        # for case of a reversed leaderboard
        # if i>=denseLB[0]:
        #     alice_rank.append(1)
        if i< denseLB[0]:
            alice_rank.append(len(denseLB)+1)
          
        # elif i < denseLB[len(denseLB)-1]:
        #     alice_rank.append(len(denseLB)+1)
        elif i >= denseLB[len(denseLB)-1]:
            alice_rank.append(1)
        else:
            #since all the arrays are sorted we can use binary search to find our required items
            alice_rank.append( find_rank(denseLB, i, 0, len(denseLB)-1))
            # l=0
            # r= len(denseLB)-1
            # while l<=r:
            #     mid=(l+r)//2
            #     if i>=denseLB[mid] and denseLB[mid-1]>i and mid-1>=0:
            #         alice_rank.append( mid+1)
            #         break
            #     else:
            # # 100, 90, 80, 75, 60
            # # 50
                        
            #         if(i>=denseLB[mid-1]):
            #             r=mid
            #         if i<denseLB[mid]:
            #             l=mid+1
            

    # alice_rank.reverse()
    return alice_rank

#---------------------------------------------------------------------------------------------------------------------------




print( 'climbingLeaderboard( [100, 90, 90, 80, 75, 60], [ 50, 65, 77, 90, 102])',climbingLeaderboard( [100, 90, 90, 80, 75, 60], [ 50, 65, 77, 90, 102]))
# print( climbingLeaderboard( [100, 90, 90, 80, 75, 60], [ 50, 65, 77, 90, 102]))
# print('climbingLeaderboard( ([100, 90 ,90, 80, 75, 60],[50 ,65, 77, 90, 102])', climbingLeaderboard( [100, 90 ,90, 80, 75, 60],[50 ,65, 77, 90, 102]))