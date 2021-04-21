def angryProfessor(k, a):
    on_time=len([i for i in a if i<=0])
    print('on_time ', on_time)
    print([i for i in a if i>=0])
    if on_time>=k:
        return 'NO'
    else:
        return 'YES'


# print(angryProfessor(4, [-93, -86, 49 ,-62, -90 ,-63 ,40, 72 ,11 ,67] ))#no
# print(angryProfessor(10, [23 ,-35 ,-2 ,58 ,-67 ,-56 ,-42 ,-73 ,-19, 37] ))#yes
# print(angryProfessor(9, [13, 91, 56, -62, 96, -5, -84, -36, -46, -13]))
# print(angryProfessor(8, [45 ,67 ,64, -50, -8, 78 ,84 ,-51 ,99, 60]))
print(angryProfessor(7,   [26 ,94, -95, 34 ,67, -97, 17 ,52 ,1, 86]))
# print(angryProfessor(2, [19 ,29 ,-17 ,-71 ,-75 ,-27 ,-56 ,-53, 65, 83]))

# print(angryProfessor(10, [-32, -3, -70, 8, -40, -96, -18, -46, -21, -79]))
# print(angryProfessor(9, [-50, 0, 64, 14, -56, -91, -65, -36, 51 ,-28]))

# print(angryProfessor(6, [-58, -29, -35, -18, 43, -28, -76, 43, -13, 6]))
# print(angryProfessor(1, [88, -17, -96, 43 ,83, 99, 25, 90, -39, 86]))

