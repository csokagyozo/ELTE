/*
4.2.1.  Declare an int variable. Calculate the largest value that can be stored in it.
        Give the variable this number as its value, then add one in a subsequent statement.
        Print the increased value.

4.2.2.  Declare an unsigned int (or char or long) variable and repeat the steps of the previous exercise.
        Use the right specifier: https://cplusplus.com/reference/cstdio/printf/
*/

#include <stdio.h> 

int main()
{

    int integer;
    printf("%d\n", sizeof(integer));

    // 2**(8*4) = 256 ** 4 = 4 294 967 296
    // signed, so maxint should be around 4 294 967 296 / 2 = 2.147.483.648
    integer = 2147483640;

    for (int i = 0; i < 10; i++) {
        printf("%d\n", integer + i);
    }

    return 0;
}
