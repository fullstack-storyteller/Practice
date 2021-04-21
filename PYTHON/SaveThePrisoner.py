def findEnd(cp, tl, s):
    tl %= cp
    res = (tl + s - 1) % cp
    if res == 0:
        res = cp
    return res
    # you are an idiot
    # relative_pos=0
    # if cp==tl:
    #     relative_pos=cp
    # elif cp<tl:
    #     relative_pos=tl%cp
    # else:
    #     relative_pos=tl
    # # now we have value relative to first position
    # if s==1:
    #     return relative_pos
    # else:
    #     if relative_pos+s-1>cp:
    #         return (relative_pos+s-1)%cp
    #     else:
    #         return relative_pos+s-1

# 2 576581 1
circle_perimeter=2
thread_length=576581
start=1
print(findEnd(circle_perimeter, thread_length, start))
print(findEnd(999999999, 999999998, 999983945))
# 999999999 999999998 999983945