

var1 =33
var2 =44
if var1 < var2:
    print("greater")
elif var1 == var2:
    print("equal")    
else:
    print("lesser")



s = set()
s.add(1)
s.add(2)
s1={4,6}
print(s.isdisjoint(s1))
# s_from_list = set([1,2,3,4])
# print(s_from_list)


words={"z":"zebra", "a":"apple", "b": "balloon"}
print("Enter your char :")
val = input()
print(words.get(val))

print("================")

numbers =[11,44,3,1,2,55,6,71,9]
#print (numbers.sort())
# numbers.reverse()
numbers.append(72)
numbers.insert(0,55)
print(numbers)

numbers.pop() #remove last one
numbers[1]=100
print(numbers)

#mutable  change                list     
#immutable => cannot change     Tuple

tp1 = (1,2,3)
#print(tp1)

tp2=(1,)
#print(tp2)

d1={"zeeshan": "burger",
    "Arooj":"Fish",
    "Hassan" : {"B":"maggie","L":"roti","D":"chicken"}}
#print(type(d1))

d1["Raffy"]="Kebabs"
print(d1)

print(d1["Hassan"]["L"])

d2 = d1.copy()

del d1["Raffy"]

print(d2.get("Raffy"))

d2.update({"Farhana":"Sweets"})

print(d2)
print("============")
print(d2.items)