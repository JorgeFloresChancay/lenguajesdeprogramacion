#ejemplo paradigma imperativo
def factorial(n):
    if n==0:
        return 1
    else:
        return n*factorial(n-1)
'''    
opcion = 1
while(opcion!=0):
    n = input("Ingrese el número: ")
    print(factorial(n))
    opcion= int(input("Ingrese el número: "))
'''

def factorialLamda(n):
    return reduce(lambda x, y: x + y, range(1, n+1))

reduce = lambda x:1 if x==0 else x*reduce(x-1)
print(reduce(5))