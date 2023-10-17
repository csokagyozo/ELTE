// "Merge" two constant ordered arrays into one. Do this with an array of pointers.

#include "stdio.h"

int main() {

    int array1[5] = {1, 2, 5, 8, 9 };
    int array2[5] = {3, 4, 6, 7, 10};

    int *pointer_array[10];

    int i = 0;
    int j = 0;
    int pind = 0;
    while (i < 5 || j < 5) {
        if (i != 5 && (j == 5 || array1[i] < array2[j])) {
            pointer_array[pind] = &array1[i];
            //printf("%i,%i,%i\n", pind, i, j);
            i++;
        } else {
            if (j != 5 && (i == 5 || array1[i] > array2[j])) {
                pointer_array[pind] = &array2[j];
                //printf("%i,%i,%i\n", pind, i, j);
                j++;
            }
        }
        pind++;
    }

    for (int i = 0; i < 10; i++) {
        printf("%i ", *pointer_array[i]);
    }

    return 0;
}