#include <stdio.h> 

int main()
{
    int a;
    int b;
    printf("a= ");
    scanf("%i", &a);
    printf("b= ");
    scanf("%i", &b);

    printf("%.2f\n", (a+b)/2.0);

    return 0;
}