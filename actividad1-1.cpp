#include <stdio.h>

int main() {
    int a, b, c, d, e, f, g, h, i, j;
    int suma;
    float promedio;

    printf("Ingrese valor 1: ");
    scanf("%d", &a);
    printf("Ingrese valor 2: ");
    scanf("%d", &b);
    printf("Ingrese valor 3: ");
    scanf("%d", &c);
    printf("Ingrese valor 4: ");
    scanf("%d", &d);
    printf("Ingrese valor 5: ");
    scanf("%d", &e);
    printf("Ingrese valor 6: ");
    scanf("%d", &f);
    printf("Ingrese valor 7: ");
    scanf("%d", &g);
    printf("Ingrese valor 8: ");
    scanf("%d", &h);
    printf("Ingrese valor 9: ");
    scanf("%d", &i);
    printf("Ingrese valor 10: ");
    scanf("%d", &j);

    suma = a + b + c + d + e + f + g + h + i + j;
    printf("La suma es: %d\n", suma);

    promedio = suma / 10.0;
    printf("El promedio es: %.2f\n", promedio);

    return 0;
}
