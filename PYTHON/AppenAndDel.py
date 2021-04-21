
def checkDiff(s, t):
    sl=len(s)
    tl=len(t)
    if sl==tl:
        for i in range(sl):
            if s[i]!=t[i]:
                return i
    else:
        # if sl>tl:
        for i in range(max(sl, tl)):
            if i<min(sl, tl) and s[i]!=t[i]:
                return i
            else:
                return min(sl, tl)
    return -1

def countChanges(s, t, i, k):
    ops=k
    add=0
    remove=0
    if len(s)< len(t):
        for j in range(i , len(t)):
            if k>0:
                k-=1
                add+=1
    if len(s)> len(t):
        for j in range(i, len(s)):
            if k>0:
                k-=1
                remove+=1
    changes=add+remove
    if len(s)==len(t):
        for j in range(i, len(s)):
            if k>0:
                k-=1
                changes+=1
    if changes-add >=0:
        return "Yes"
    else:
        return "No"

        

        
    # changes=0
    # for j in range(i, len(s)):
    #     changes+=1
    # for j in range(i, len(t)):
    #     changes+=1
    # if changes>k:
    #     return "No"
    # else:
    #     if len(s)<len(t):
    #         return "No"
    #     else:
    #         return "Yes"

# Complete the appendAndDelete function below.
def appendAndDelete(s, t, k):
    x=checkDiff(s, t )
    if x==-1:
        return "Yes"
    else:
        return countChanges(s, t, x, k)
        # we just have to compare the count of changes
print(appendAndDelete('y', 'yu', 2))




















# # # s =list("hackerhappy")
# # # t =list("hackerrank")
# # s='ashley'
# # t='ash'
# t='y'
# s='yu'
# def checkDiff():
#     sl=len(s)
#     tl=len(t)
#     if sl==tl:
#         for i in range(sl):
#             if s[i]!=t[i]:
#                 return i
#     else:
#         # if sl>tl:
#             for i in range(max(sl, tl)):
#                 if i<min(sl, tl) and s[i]!=t[i]:
#                     return i
#                 else:
#                     return min(sl, tl)
#     return -1
       
# #     temp=0
# #     for i in range(sl):
        
# #         if i<tl and s[i]==t[i]:
# #             temp= i
# #         else:
# #             break

# #     # return -1
# #     # for i in range(min(sl, tl)):
# #     #     if i<max(sl, tl) and s[i]!=t[i]:
# #     #         return i
# #     # if (sl<tl):
# #     #     for i in range(tl):
# #     #         if i <sl and s[i]!=t[i]:
# #     #             return i
# #     # else:
# #     #     for i in range(sl):
# #     #         if i <tl and s[i]!=t[i]:
# #     #             return i

# #     # for i in range(max(sl, tl)):
# #     #     if i < sl and s[i]!=t[i]:
# #     #         return i
# #     # return -1
# print(checkDiff())
# # # s=list("abc")
# # # t=list("def")
# # # t =list("hackerhappy")
# # # s =list("hackerrank")


# # # s =list("hackerrank")
# # # t =list("hackerrank")

# # # def delTillMismatch(i, k):
    
# # #     for j in range(i, len(s)):
# # #         if k>0:
# # #             s.pop()
# # #             k-=1
# # #         else:
# # #             break
# # #     if k>0:
# # #         return k
# # #     else:
# # #         return 0



# # # def appendFromMismatch(i, k):
# # #     if k==0 and checkDiff() ==-1:
# # #         return "Yes"
# # #     else:
# # #         for j in range(i, len(t)):
# # #             if k>0:
# # #                 s.append(t[j])
# # #                 k-=1
# # #         if k==0 and checkDiff()==-1:
# # #             return "Yes"
# # #         else:
# # #             return "No"



# # def countChanges(i, k):
# #     changes=0
# #     for j in range(i, len(s)):
# #         changes+=1
# #     for j in range(i, len(t)):
# #         changes+=1
# #     if changes>k:
# #         return "No"
# #     else:
# #         return "Yes"
    


# # def AppenAndDel( k):
    
# #     x=checkDiff()
# #     if x==-1:
# #         return "Yes"
# #     else:
# #         return countChanges(x, k)

# #     # mismatch contains the index in both s and t where the mismatch actually started happening
# #         # return appendFromMismatch( x, delTillMismatch( x, k))
    
    
    


# # # print(appendFromMismatch(6, 2))
# # # print(delTillMismatch(6, 6))


# # # print(checkDiff())
# # # print(AppenAndDel([a, b, c], [d, e, f], 6 ))
# # # print(AppenAndDel(8))