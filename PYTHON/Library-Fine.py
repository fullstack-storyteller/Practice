# # return date : d1, m1, y1
# # due date: d2, .2, y2
# # if y1 > y2 => 10000
# #  else 
# def isLeapYear(y):
#     if y%4==0:
#         return True
#     elif y%100 ==0 and y%400==0:
#         return True
#     else :
#         False


# def remainingDays(d, m, y):

#     D={1: 31, 3: 31, 4:30, 5:31, 6:30, 7:31, 8:31, 9:30, 10:31, 11:30, 12: 31}
#     if isLeapYear(y):
#         D[2]=29
#     else:
#         D[2]=28
#     return D[m]-d

def libraryFine(d1, m1, y1, d2, m2, y2):
    if y1> y2:
        return 10000
    elif y1==y2:
        # do something
        if m1>m2:
            return (m1-m2)*500
        elif m1==m2:
            # do something
            if d1>d2:
                return (d1-d2)*15
            else:
                return 0
        else:
            return 0

    else: # y1<y2 i.e. zero fine
        return 0
        
print(libraryFine(9,6,2015, 6, 6, 2015))
    