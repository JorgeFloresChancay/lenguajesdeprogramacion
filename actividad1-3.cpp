#include <stdio.h>

int main() {
    char *sucursales[] = {
        "Sucursal1", "Sucursal2", "Sucursal3", "Sucursal4", "Sucursal5",
        "Sucursal6", "Sucursal7", "Sucursal8", "Sucursal9", "Sucursal10",
        "Sucursal11", "Sucursal12", "Sucursal13", "Sucursal14", "Sucursal15",
        "Sucursal16", "Sucursal17", "Sucursal18", "Sucursal19", "Sucursal20",
        "Sucursal21", "Sucursal22", "Sucursal23", "Sucursal24", "Sucursal25"
    };
    int ventas[] = {
        1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
        11, 12, 13, 14, 15, 16, 17, 18, 19, 20,
        21, 22, 23, 24, 25
    };
    int totalVentas = 0;
    float promedio;
    int i;

    for (i = 0; i < 25; i++) {
        totalVentas += ventas[i];
    }
    promedio = totalVentas / 25.0;

    printf("Promedio de ventas: %.2f\n", promedio);
    printf("Las sucursales que vendieron más son:\n");

    for (i = 0; i < 25; i++) {
        if (ventas[i] > promedio) {
            printf("%s\n", sucursales[i]);
        }
    }

    return 0;
}
