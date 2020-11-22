import random

i=11

while (i <= 10):
    randints = random.randint(0,5)
    print(" Rand ints " , end="")
    print(randints)

#generate random numbers till 100
    randNumbers = random.random() * 100
    print(" Rand Nos " , end="")
    print(randNumbers)

    i=i+1

lst =["start", "dd1", "aaj" , "code"]
choice = random.choice(lst)
print(choice)