import math
def encryption(s):
    text =s.rstrip().replace(" ", "")
    result=[]
    length=len( text)
    lower_bound= math.floor(math.sqrt(length))
    upper_bound= math.ceil(math.sqrt(length))
    ##
    # lower_bound * lower_bound
    # lower_bound * upper_bound
    # upper_bound * upper_bound
    # #

    # 7, 8   8, 8   7, 7
    possible_dimensions=[]
    possible_dimensions.append((lower_bound, lower_bound))
    possible_dimensions.append((lower_bound, upper_bound))
    possible_dimensions.append((upper_bound, upper_bound))
    # print(posibble_dimensions)
    
    rows=0
    cols=0
    # maxarea=upper_bound*upper_bound
    for i in possible_dimensions:
        a=i[0]*i[1]
        if a>=length:
            rows=i[0]
            cols=i[1]
            break
    possible_dimensions.clear()
    
    # print(rows, cols)
    if rows==cols: # think about it, why was it needed.
        rows-=1
    for i in range(rows+1):
        for j in range(cols):
            if j*cols + i<length:
                result.append(text[j*cols+i])
        result.append(" ")
    return ''.join(result)



string = "if man was meant to stay on the ground god would have given us roots"
# string="haveaniceday"
# string="feedthedog"
# string="chillout"
print(encryption(string))

# ifmanwasmeanttostayonthegroundgodwouldhavegivenusroots

# ifmanwas  
# meanttos          
# tayonthe  
# groundgo  
# dwouldha  
# vegivenu  
# sroots
# # the above is possible 
# ifmanwa
# smeantt
# ostayon
# thegrou
# ndgodwo
# uldhave
# givenus
# roots
# # the above is not possible