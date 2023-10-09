/*
4.2.5.  Try operator chaining (a < b < c, a = b = c).
*/

#include <stdio.h> 

int main()
{
    if (1 < 2 < 3) // (1 < 2) < 3
    {
        printf("1 < 2 < 3\n");
    }
    
    if (3 > 2 > 1) // (3 > 2) > 1
    {
        printf("3 > 2 > 1\n");
    }

     return 0;
}
