#define MAX_LINE_LEN 40

#include <stdio.h>

int main() {
    char input[MAX_LINE_LEN];
    printf("%s", "please write a short sentence (max. 40 characters): ");
    //scanf("%s", input);
    fgets(input, MAX_LINE_LEN, stdin);
    printf("%s\n", input);
    
    char filename[MAX_LINE_LEN];
    printf("%s", "please type the name of the output file: ");
    scanf("%s", filename);
    printf("%s\n", filename);
    
    FILE * fp;
    //fp = fopen ("file.txt", "w");
    fp = fopen(filename, "a+");
    fprintf(fp, "%s %s\n", "The user input was:", input);
    fclose(fp);

    fp = fopen(filename, "r");
    char line[40];
    while (fgets(line, MAX_LINE_LEN, fp)) {
        //fscanf(fp, "%s", line);
        if (feof(fp)) {
            break;
        }
        printf("%s", line);
    }
    fclose(fp);
    return 0;
}