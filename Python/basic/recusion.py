result =0
def factorial(n):
    if n ==1:
        return 1
    else:
        return n * factorial(n-1)


    # if(n > 0):
    #     global result
    #     result = n * (n-1)
    #     n=n-1
    #     factorial(n)