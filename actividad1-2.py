import random
pares=0
impares=0
for i in range(500):
    numero = random.randint(50, 100)
    if numero%2==0:
        pares=pares+1
    else:
        impares=impares+1
    print(numero)

print(f"Cantidad de pares: {pares}")
print(f"Cantidad de impares: {impares}")
