#include <stdio.h> 
#include <limits.h>

int main()
{
    char c = 'X';
    int i;
    float f;
    double dbl;
    printf("size of char: %li\n", sizeof(c));
    printf("size of int: %li\n", sizeof(i));
    printf("size of float: %li\n", sizeof(f));
    printf("size of double: %li\n", sizeof(dbl));
    printf("i++ loop\n");
    i = 0;
    while (i<10)
    {
        printf("%i\n", i++);
    }
    printf("++i loop\n");
    i = 0;
    while (i<10)
    {
        printf("%i\n", ++i);
    }


    return 0;
}