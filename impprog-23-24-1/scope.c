/*
discuss together:
7.2.1. Declare and define a variable outside the main() function! Change its value and write it out!
7.2.2. Create a function, declare and define a variable in it! Can you access the variable outside the function?
7.2.3. Write an if statement in the function written in the previous task after the variable definition! Check whether you reach the variable in the condition of if and in the true block, and optionally in the branch of else and else if!
7.2.4. Declare and define a variable in any branch of an if statement, or in the body of an arbitrary loop! Check whether you can reach the variable outside the block!
7.2.5. Create nested scopes (blocks between {} pairs), introduce a variable in each! Check which variables you reach from which scope. When is it worth using scopes? What is the stack and how is it connected to scope management?
7.2.6. Declare a function in advance, then define it separately, using different parameter names as parameters. What's happening? When can this be useful?
7.2.7. Declare a two-parameter function, using the same variable name for two parameters. What happens?

exercises:
*7.2.8. Create a function, declare and define a static variable in it. Increase the value of the variable and print it out! Call the function in main() several times. What happens?
*7.2.9. Write a swap() function that exchanges the values of two int variables!
*7.2.10. Write a function that expects two int pointers as parameters and returns the pointer pointing to the greater value.
*7.2.11. Declare and define a variable in the core of a loop, then embed a second loop and check whether you can reach the variable declared in the outer loop!
*7.2.12. Use a static variable to create a factorial function that counts the number of times it was called with parameters!

*/

#include "stdio.h"

int global = 10;

int myFunc();
int add(int a, int b);

int funcWithStatic() {
    static int stat = 0;
    stat = stat + 1;
    return stat;
}

void swap(int* a, int* b) {
    int temp = *a;
    *a = *b;
    *b = temp;
}

int* greater(int* a, int* b) {
    if (*a > *b)
        return a;
    else
        return b;
}

int factorial(int p) {
    static int counter = 0;
    counter++;
    printf("Factorial function has been called %i times so far\n", counter);
    int fact = 1;
    for (int i = 1; i <= p; i++) {
        fact = fact * i;
    }
    return fact;
}

int main() {
    int funcValue = myFunc();
    printf("%i\n", funcValue);
    for (int i = 0; i < 10; i++) {
        printf("%i\n",funcWithStatic());
    }

    int x = 12;
    int y = 8;
    printf("x = %i, y = %i\n", x, y);
    swap(&x, &y);
    printf("x = %i, y = %i\n", x, y);

    printf("The greater of the two is: %i\n", *greater(&x, &y));

    for (int i = 1; i <= 5; i++) {
        printf("%i\n",factorial(i));
    }

    return 0;
}

int myFunc() {
    int var = 0;
    return var;
}

int add(int a, int b){
    return a+b;
}

int func(int num) {
    return num;
}

