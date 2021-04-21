#practice
for x in (2, 20, 200)
    print(x)''

list_pt=list('Welcome')
print(list_pt[:])
print(list_pt)
print(min('Infinity'))
print(bool(5))

#practice - go below for sets


#sets are immutable and have no duplicates
#frozensets can't be updated

a=set(['10', '20', '30', '40'])
b=set(['30', '60'])
print(a)
print(b)

#union
print(a.union(b))
print(a|b)

#intersection
print(a.intersection(b))
print(a&b)

#difference
print(a-b)
print(a.difference(b))

#symeetric difference
print(a.symmetric_difference(b))
print((a|b) - (a&b))

d={}
d['t']='talk'
d['v']='vibe'

print(d)
d1=d.copy()
print(d1)
del(d['v'])
print(d)
