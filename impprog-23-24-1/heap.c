/*
8.3.1. Write a program that asks the user for a text of up to 20 characters and
   makes a copy of it. Make sure that the copy only uses as much memory space as
   is absolutely necessary.
8.3.2. Create a function called `reverse()` that has a string parameter. The
   function should reverse the characters of the string locally. That is, the
   function returns the result in the same memory area that it received as a
   parameter. For example, the characters of a palindrome string are not changed
   in the function.
8.3.3. Modify the previous `reverse()` function so that it does not replace the
   characters locally, but creates another string and returns with it. Reserve
   the necessary memory dynamically!
*/
#include <stdio.h>
#include <string.h>
#include <stdlib.h>

void reverse(char* inputString);
char* reverse2(char* inputString);

int main() {
    char input[20];
    fgets(input, 20, stdin);

    int len = strlen(input);
    //ptr = (int*)malloc(n * sizeof(int));
    char* ptr = (char*)malloc(len);
    for (int i = 0; i < len; i++) {
        ptr[i] = input[i];
    }
    for (int i = 0; i < len - 1; i++) {
        printf("%i %c\n", i, ptr[i]);
    }
    
    printf("input: %s\n", ptr);
    reverse(ptr);
    printf("input: %s\n", ptr);
    char* result = reverse2(ptr);
    printf("input: %s\n", ptr);
    printf("input2: %s\n", result);

    free(ptr);
    return 0;
}


void reverse(char* inputString) {
    int len = strlen(inputString) - 1;
    printf("from the reverse function %s\n", inputString);
    for (int i = 0; i < strlen(inputString)/2; i++) {
        char tmp = inputString[i];
        inputString[i] = inputString[len - i];
        inputString[len - i] = tmp;
    }
}

char* reverse2(char* inputString) {
    int len = strlen(inputString) - 1;
    char* ptr = (char*)malloc(len);
    for (int i = 0; i <= len; i++) {
        ptr[len-i] = inputString[i];
    }

    return ptr;
}
