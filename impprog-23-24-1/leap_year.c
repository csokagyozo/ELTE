/*
4.2.3.  Write a program that determines whether the number is a leap year from the standard input.
        A leap year is any year divisible by four, except those divisible by a hundred.
        However, those divisible by four hundred will also be leap years.
*/

#include <stdio.h> 

int main()
{
    int year;
    printf("Choose a year between 1 and 2 147 483 647: \n");
    scanf("%i", &year);

    printf("This is a leap year: %s", year % 4 == 0 && (year % 100 != 0 || year % 400 == 0 || year) ? "true" : "false");

     return 0;
}
