
def nonDivisibleSubset(k, s):
    print([i%k for i in s])


print(nonDivisibleSubset(3, [1, 7, 2, 4]))
print(nonDivisibleSubset(7, [278, 576, 496 ,727, 410, 124, 338, 149, 209, 702, 282, 718, 771, 575, 436]))
