with open('D:/Practice/PYTHON/test/fruits.txt') as old:

    with open('D:/Practice/PYTHON/test/veggies.txt', 'w') as new_file:
        new_file.write('tomato\nspinach')#this will overide the existing content of the file, if it already exiting/open, or it will created a brand new file
        new_file.write('\ngarlic')
        new_file.write(old.read()[5:])

# with open('fruits.txt', 'a') as file:#append mode adds to the existing file but can't read the file
with open('fruits.txt', 'a+') as file:#it can read the file too
    file.write('\nokra')
    file.seek(0)#bringing the file cursor back to start as it is at end right now
    print(file.read())