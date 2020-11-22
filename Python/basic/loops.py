def addTwoByTwo(a,b):
    """ this is a string """
    return a + b + a +b;
try:
    print(addTwoByTwo.__doc__)
    result = addTwoByTwo(2,3)
except Exception as e:
    print(e)


list1 = [
    ["harry",1,5],
    ["marry",2,6],
    ["garry",3,7]
]
for item , looy, rebate in list1:
    print(item ,"and looy is ", looy, "rebate is ", rebate)

#dict1 = dict(list)

items =[int, float, "herry",5,3,3,2,44,55,66,77]
for item in items:
    if str(item).isnumeric() and item > 6:
        print(item)
 
i =1

while (i<45):
    i=i+1
    if i==44:
        break
    elif i>30 and i<40:
        continue
    print(i, end=" ")
    
    