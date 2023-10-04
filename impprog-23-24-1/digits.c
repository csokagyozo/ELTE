#include <stdio.h> 

int main()
{
    int a;
    printf("a= ");
    scanf("%i", &a);

    int digit = 0;
    int sum = 0;

    while (a>0) {
        digit = a % 10;
        printf("a=%i, last digit=%i\n", a, digit);
        a = a / 10;
        sum = sum + digit;
    }
    printf("%i\n", sum);

    return 0;
}