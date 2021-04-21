

def getShiftedString(s, leftShifts, rightShifts):
    i = (leftShifts - rightShifts) % len(s)
    return s[i:] + s[:i]

print(getShiftedString('abcd', 1, 2))