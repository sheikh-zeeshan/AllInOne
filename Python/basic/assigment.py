val=2
rows =5
charToPrint="*"
if val==1:
    for x in range(rows):
        if x > 0:
            print(x * charToPrint)
elif val==2:
    for x in range(rows,0,-1):
        print(x * charToPrint) 