print([ chr(i) for i in [65, 66, 67] ])


string ='manishk-!'
special ='!-%$'

word=[i for i in string if i not in special]

print(word)
word.reverse()
print(''.join(word))
test =''.join(word)
# print(string)
print(test[:3])
print(test)

string='manish kumar   singh'
print(''.join([i for i in string if i!=' ']))


for k in word:
    print(k)
