


import re


# Complete the function below.
def subst(pattern, replace_str, string):
    #susbstitute pattern and return it
    return re.sub(pattern, replace_str, string)


def main():
    addr = ['100 NORTH MAIN ROAD',
            '100 BROAD ROAD APT.',
            'SAROJINI DEVI ROAD',
            'BROAD AVENUE ROAD']
            
    #Create pattern Implementation here 
    
    #Use subst function to replace 'ROAD' to 'RD.',Store as new_address
    new_address=[]
    for i in addr:
        new_address.append(subst('\ ROAD', ' RD.', i))

    return new_address

# '''For testing the code, no input is required'''

# if __name__ == "__main__":
#     f = open(os.environ['OUTPUT_PATH'], 'w')

#     res = main();
#     f.write(str(res) + "\n")


#     f.close()
print(main())
