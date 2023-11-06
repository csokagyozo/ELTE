/*
6.1. Change the value of a variable via a pointer.
6.2. Change the value of a pointer through a pointer to a pointer. Then change the value pointed by the pointed pointer as well!
6.3. Can you create a pointer to itself? What would be its type? Why not? Compare the sizes of pointers to different types of variables. Explain why the result is logical!
6.15. How does pointer arithmetic works in a multi-dimensional array?
*/
#include "stdio.h"

int main() {

    // what is the difference between these two?
    int *pointer;
    int variable;

    pointer = 0;
    variable = 0;

    //printf("%i,%i,%i\n", pointer, *pointer, variable);
    printf("%p,%i\n", pointer, variable);

    // what will be printed out?
    pointer = &variable;
    printf("%p,%i\n", pointer, variable);

    *pointer = 10;
    printf("%p,%i\n", pointer, variable);

    // now what does this mean and how can we use it?
    int ***ppp = 0;
    int ** pp = 0;
    int *p = 0;
    int integer;

    printf("%p,%p,%p,%i\n", ppp, pp, p, integer);
    p = &integer;
    printf("%p,%p,%p,%i\n", ppp, pp, p, integer);
    pp = &p;
    printf("%p,%p,%p,%i\n", ppp, pp, p, integer);
    ppp = &pp;
    printf("%p,%p,%p,%i\n", ppp, pp, p, integer);
    ***ppp= 10;
    printf("%p,%p,%p,%i\n", ppp, pp, p, integer);


    int arr[10] = {1,2,3,4,5,6,7,8,9,10};
    int twoDimArr[3][3] = {{1,2,3},{4,5,6},{7,8,9}};
    int *q = arr;
    int *r = twoDimArr[0];

    for (int i = 0; i < 12; i++) {
        printf("%p,%i\n", q, *q);
        q++;
    }

    for (int i = 0; i < 9; i++) {
        printf("%p,%i\n", r, *r);
        r++;
    }

    return 0;
}