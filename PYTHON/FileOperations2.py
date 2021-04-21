with open('data.txt', 'a+') as file:
    file.seek(0)
    #when the file is opened in append mode, by default the cursor is at its end
    #so if you want to read the file in append mode, make to sure to seek to oth position
    content=file.read()
    times=0
    while times<2:
        file.write(content)
        times=times+1