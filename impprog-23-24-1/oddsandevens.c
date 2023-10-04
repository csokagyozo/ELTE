#include <stdio.h> 

int main()
{
    int a;
    printf("a= ");
    scanf("%i", &a);

    int digit;
    int countOdd = 0;
    int countEven = 0;

    while (a>0) {
        digit = a % 10;
        a = a / 10;
        if (digit % 2 == 0) {
            countEven = countEven + 1;
        } else {
            countOdd = countOdd + 1;
        }
    }
    printf("number of even digits: %i\n", countEven);
    printf("number of odd digits: %i\n", countOdd);
    
    return 0;
}