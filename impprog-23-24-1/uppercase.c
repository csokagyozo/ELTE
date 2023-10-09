/*
4.2.4.  Read a character and convert it to uppercase if it's lowercase and vice versa. 
*/

#include <stdio.h> 

int main()
{

    char letter;
    printf("Type one letter, then press enter: \n");
    scanf("%c", &letter);

    if (letter < 65 || letter > 122 || (letter > 90 && letter < 97)) {
        printf("This is a strange one, indeed: %c\n", letter);
        return 0;
    }

    if (letter <= 90) {
        printf("This is a uppercase letter (%c), here is the lowercase version of it: %c\n", letter, letter + 32);
    } else {
        printf("This is a lowercase letter (%c), here is the uppercase version of it: %c\n", letter, letter - 32);
    }

    return 0;
}
