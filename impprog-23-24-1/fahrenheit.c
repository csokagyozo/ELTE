#include <stdio.h> 

int main()
{
    for (int i = 0; i <= 120; i += 10)
    {
        double c = (i - 32) / 1.8;
        printf("%iF = %.3fC\n", i, c);
    }
    return 0;
}