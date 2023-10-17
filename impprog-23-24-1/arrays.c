/*
5.2.1. Create a program which fills up an array with zeros.
5.2.2. Create a program which adds up the integers of an array.
5.2.3. Create a program which prints the greatest element of an array.
5.2.4. Create a program which prints the second lowest element of an array.
5.2.5. Create a program which swaps the smallest and greatest elements of an array.
5.2.6. Create a program which calculates the weighted sum of an array. The weights are listed in another array. For example: first array: [1, 2, 3, 4, 5], second array: [1, 1, 2, 3, 5]. Weighted sum: 1*1 + 1*2 + 2*3 + 3*4 + 5*5.
5.2.7. Calculate the average of some floating point numbers in an array.
*/

#include "stdio.h"

void printArray(int someIntegers[]) {
    for (int i=0; i < 10; i++) {
        printf("the %i. element of the array is %i\n", i, someIntegers[i]);
    }
}

int main() {

    int someIntegers[10];

    printf("the %i. element of the array is %i\n", 0, someIntegers[0]);
    someIntegers[0] = 42;
    printf("the %i. element of the array is %i\n", 0, someIntegers[0]);

    for (int i=0; i < 20; i++) {
        printf("the %i. element of the array is %i\n", i, someIntegers[i]);
    }

    // Fill with zeros
    for (int i=0; i<10; ++i) {
        someIntegers[i] = 0;
    }

    printArray(someIntegers);

    // Fill with values from 0 to 18
    for (int i=0; i<10; ++i) {
        someIntegers[i] = (5-i)*3;
    }

    printArray(someIntegers);

    // sum
    int sum = 0;
     for (int i=0; i < 10; i++) {
        sum += someIntegers[i];
        printf("added %i to %i\n", someIntegers[i], sum);
    }
    printf("sum = %i\n", sum);

    // find the maximum value
    int max = someIntegers[0];
    for (int i=0; i < 10; i++) {
        if (someIntegers[i] > max) {
            max = someIntegers[i];
        }
    }
    printf("max = %i\n", max);

    // find the second smallest value
    int min = someIntegers[0];
    int sec_smallest = someIntegers[0];

    for (int i=0; i < 10; i++) {
        if (someIntegers[i] < min) {
            sec_smallest = min;
            min = someIntegers[i];
        } else {
            if (someIntegers[i] < sec_smallest) {
                sec_smallest = someIntegers[i];
            }
        }
    }
    printf("The second smallest value is: %i\n", sec_smallest);

    // Swap smallest and greatest elements of the array
    int minIndex = 0;
    min = someIntegers[0];
    int maxIndex = 0;
    max = someIntegers[0];

    for (int i=0; i < 10; i++) {
        if (someIntegers[i] > max) {
            max = someIntegers[i];
            maxIndex = i;
        }
        if (someIntegers[i] < min) {
            min = someIntegers[i];
            minIndex = i;
        }
    }

    int temporary = someIntegers[minIndex];
    someIntegers[minIndex] = someIntegers[maxIndex];
    someIntegers[maxIndex] = temporary;

    printArray(someIntegers);

    return 0;
}

