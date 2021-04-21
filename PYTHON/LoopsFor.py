colors =['red', 'black', 'green', 'orange']# list
for color in colors:
    print(color.title())

colors_dict ={'red': 1, 'black':2, 'green':3, 'orange':4}# dictionary
for color in colors_dict.values():
    print(color)
for color in colors_dict.keys():
    print(color.upper())

for key, value in colors_dict.items():
    print('{} is color and {} is color code'.format(key, value))

for color in colors_dict.items():
    # print('{} is color and {} is color code'.format(color[0], color[1]))#color is this case is tuple, i.e. dictionary is behaving like a collection of tuples
    print('%s is color and %s is color code'%(color[0], color[1]))