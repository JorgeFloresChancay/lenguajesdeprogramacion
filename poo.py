class CuentaBancaria:
    
    def __init__(self,nombre,saldo):
        self.nombre=nombre
        self.saldo=saldo
    
    def depositar(self,cantidad):
        self.saldo+=cantidad
        
    def retiro(self,cantidad):
        if cantidad> self.saldo:
            return ValueError("Saldo insuficiente, pruebe con: ", self.saldo)
        else:
            self.saldo-cantidad
    
    def __str__(self):
        return f"Cuenta bancaria de {self.nombre}. Saldo {self.saldo}"
    
    
cuenta1 = CuentaBancaria("Jorge", 10000)
cuenta2 = CuentaBancaria("Luisa", 30000)
cuenta3 = CuentaBancaria("Ariel", 20000)

print(cuenta1)
print(cuenta2)
print(cuenta3)
cuenta1.depositar(500)
cuenta2.depositar(400)
cuenta3.depositar(300)
print(cuenta1)
print(cuenta2)
print(cuenta3)
cuenta1.retiro(100)
cuenta2.retiro(100)
cuenta3.retiro(100)
print(cuenta1)
print(cuenta2)
print(cuenta3)