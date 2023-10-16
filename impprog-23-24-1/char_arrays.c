/*
5.3.1. Create a program which calculates the length of a string.
5.3.2. Create a program which gets two strings as input and determines which one precedes the other in lexicographical order.
5.3.3. Create a program which gets a string and prints the number of lines.
5.3.4. Write a program which counts the number of vowels and consonants in a string. // vowels: A, E, I, O, U
*/

#include "stdio.h"

int main() {

    char cString1[] = "abrakadabra";
    char cString2[] = "hocuspocus";

    printf("%s\n", cString1);

    cString1[0] = 'h';
    cString1[1] = 'o';
    cString1[2] = 'c';

    printf("%i\n", cString1[0]);

    scanf("%s", cString1);

    int i = 0;
    while (cString1[i] != 0) {
        printf("the %i. element of the array is %c\n", i, cString1[i]);
        i++;
    }

    // let's assume our string has only lowercase characters from the latin alphabet
    // compare them character by character
    i = 0;
    while (cString1[i] != 0 || cString2 !=0) {
        if (cString1[i] < cString2[i]) {    
            printf("%s comes first\n", cString1);
            break;
        }
        if (cString1[i] > cString2[i]) {
            printf("%s comes first\n", cString2);
            break;
        }
        i++;
    }

    return 0;
}