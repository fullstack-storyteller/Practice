# s='Manish'
# k='Manish'
# print(s==k)
strings=['aba', 'baba', 'aba', 'xzxb']
queries=['aba', 'xzxb', 'ab']

def matchingStrings(strings, queries):
    d={}
    for i in strings:
        if i not in d.keys() or d=={}:
            d[i]=1
        else:
            d[i]+=1
    result=[]
    for q in queries:
        if q in d.keys():
            result.append(d[q])
        else:
            result.append(0)
    return result

def matchingStrings1(strings, queries):
    result=[]
    for qs in queries:
        result.append( strings.count(qs) )
    return result

print(matchingStrings(strings, queries))
print(matchingStrings1(strings, queries))