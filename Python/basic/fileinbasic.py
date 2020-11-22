# r -> read file for opening    default
# w -> for wroting
# x -> file create if not exists
# a -> append at end
# t -> text mode (text file)    default
# b -> binary mode
# + -> read and write 

f= open("harry.txt", "rt")

val=1

if val==1:
    content = f.read()
    print(content)

elif val==2:
    content = f.read()
    for line in content:
        #print(f.tell()) #file pointer location
        #f.seek(1)# reset pointer to first char
        print(line, end="")    

elif val==4:
    print(f.readline())
    print(f.readline())
else:
    for line in f:
        print(line, end="")

f.close()

f= open("harry.txt", "a") #w mode clears and override the text
noOfCharsAppended = f.write("\nzeeshan asghar ")
f.close()

f=open("harry.txt", "r+") #read and write
print(f.read())
f.write("thanks you")

with open("harry.txt") as f:
    a= f.read(4)
    print(a)

l=10

def getDate():
    import datetime
    return datetime.datetime.now()

def function(b):
    global l
    l=l+b

print(l)