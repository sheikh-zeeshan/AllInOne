def add(a,b):
    return a+b

minus = lambda x, y : x-y
print(minus(9,4))

def a_first(a):
    return a[1]

a = [[1,4], [5,6],[8,23]]
#a.sort(key=a_first)

a.sort(key=lambda x: x[1])
print(a)
