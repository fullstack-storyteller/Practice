myfile=open('fruits.txt')
#i mistakenly saved the file as fruits,txtx.txt
#only the name is enough as the fruits.txt is present in the same working directory
content=myfile.read()
#now the cursor is at the end of the file, so the below will return empty string
print(content)
print(myfile.read())
myfile.close()

def count_chars(character, path):
    with open(path, 'r') as file:#opened for read and this will help automatically close the file
        content=file.read()
        print(content)
    return content.count(character)
print(count_chars('a', 'D:/Practice/PYTHON/test/fruits.txt'))# backslash is not  working in python, change them to forward slash
# print(content)# this will not work as content is out of scope