#A list comprehension is an expression
#which creates a list by dynamically iterating over another container

temps=[222, 223, 240, 240.4, 245.9]

#way 1
new_temp=[]
for temp in temps:
    new_temp.append(temp/10)
print(new_temp)

# another way to do the same
#in this case the new list will be generated dynamically

new_temp1=[temp / 10 for temp in temps]
print(new_temp1)


temps=[222, 223, 240, 240.4, 245.9, -9999,-720.1]# -9999 is supposed to ignore as a organization may use such constants to recorded un measurable data
new_temp2=[temp /10 for temp in temps if temp!= -9999]
print(new_temp2)


def only_numbers(listing):
    return [number for number in listing if isinstance(number, int)]

print(only_numbers([99, 23.1, 234, 'not int', 'x', 41.3, 8]))


def only_numbers_with_else(listing):
    return [number if type(number)== int else -1 for number in listing ]

print(only_numbers_with_else([99, 23.1, 234, 'not int', 'x', 41.3, 8]))

def sum_string (listing):
    return sum([float(num) for num in listing])
print(sum_string(['1.2','2.3','4.23','9.01']))