def mean(mylist):
    if isinstance(mylist, dict):
    #if type( mylist) == dict: #note here we need to specify the dict without any quotes/ double quotes
        print(mylist)
        return sum(mylist.values())/len(mylist)
    else:
        print(mylist)
        return sum(mylist)/len(mylist)

print(mean([2, 3, 5, 3]))
print(mean({'Manish':2, 'Priyant':3, 'Raju':5, 'Adrak':3}))
# but this code will not support a dictionary class