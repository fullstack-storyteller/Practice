numbers=[23.1, 34.6, 89.3,45]
print('the number list is ',numbers, 'it has length ', len(numbers), 'with sum = ',sum(numbers), 'and mean =', sum(numbers)/len(numbers))
print(numbers.count(10.0))


my_numbers={'Science':23.1, 'SST':34.6, 'GK':89.3,'Sanskrit':45}

print('My mean number ',sum(my_numbers.values())/len(my_numbers))
my_tuple=(1, 3,4.5, "manish")
print(my_tuple, my_tuple.count(0))