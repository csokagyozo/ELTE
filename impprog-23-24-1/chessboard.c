/*
4.2.6.  Draw an empty chessboard. Mark dark fields with [], light fields and two spaces. Use divisibility by two.
*/

#include <stdio.h> 

int main()
{

    for (int i = 0; i < 8; i++) {
        for (int j = 0; j < 8; j++) {
            if ((i + j) % 2 == 0) {
                printf("  ");
            } else {
                printf("[]");
            }
        }
         printf("\n");
    }

    return 0;
}
