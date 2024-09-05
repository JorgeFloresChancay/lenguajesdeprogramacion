
sucursales = ["Sucursal1","Sucursal2","Sucursal3","Sucursal4","Sucursal5","Sucursal6","Sucursal7","Sucursal8","Sucursal9","Sucursal10",
              "Sucursal11","Sucursal12","Sucursal13","Sucursal14","Sucursal15","Sucursal16","Sucursal17","Sucursal18","Sucursal18","Sucursal20",
              "Sucursal21","Sucursal22","Sucursal23","Sucursal24","Sucursal25"]
ventas = [1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25]

promedio = 0

for i in ventas:
    promedio= promedio+i

promedio= promedio/25
print(f"Promedio de ventas: {promedio}")
print("Las sucursales que vendieron más son: ")
for i in range(25):
    if ventas[i] > promedio:
        print(sucursales[i])