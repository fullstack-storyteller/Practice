def repeatedString(s, n):
    # len of s
    # does s contains a
        # if yes then how many a's, i.e. one occurene of s
        # if no then return 0
    # given n compared with length of the string s
        # n< s, then s will not be repeated
        # n>=s, then s will be written atleast once
    sl= len(s)
    acount=list(s).count('a')
    if 'a' in s:
        #do something
        if n==sl:
            return acount
        elif n<sl:
            return list(s)[:n].count('a')
        else:
            reps=n//sl
            # print('reps', reps)
            remainingLength=n%sl
            # print('remaining length', remainingLength)

            # print( reps*acount )
            # print( list(s)[:remainingLength].count('a'))
            return reps*acount + list(s)[:remainingLength].count('a')
    else:
        return 0

# print(repeatedString('aba', 4))
print(repeatedString('a', 1000000000000))
# print(repeatedString('aba', 10))
        
