#include <stdlib.h>
#include <stdio.h>

struct box {
    int val;
    struct box* next;
};

struct box* create_stack() {
    return NULL;
}

int empty(struct box* stack) {
    return stack == NULL;
}

int peek(struct box* stack) {
    if (!empty(stack)) {
        return stack->val;
    } else {
        //e.g. throw an error
        return -1;
    }
}

void push(struct box** stack, int v) {
    struct box* top = *stack;
    struct box* new_top = malloc(sizeof(struct box));
    new_top->val = v;
    new_top->next = top;
    *stack = new_top;
}

void pop(struct box** stack) {

    struct box* top = *stack;

    if (!empty(top)) {
        struct box* old_top = top;
        *stack = top->next;
        free(old_top);
    } else {
        //e.g. throw an error
    }
}

int main() {

    struct box* stack = create_stack();
    printf("%i ", peek(stack));
    push(&stack, 5);
    printf("%i ", peek(stack));
    push(&stack, 10);
    printf("%i ", peek(stack));
    push(&stack, 7);
    printf("%i ", peek(stack));
    pop(&stack);
    printf("%i ", peek(stack));
    pop(&stack);
    printf("%i ", peek(stack));
    pop(&stack);
    printf("%i ", peek(stack));

    return 0;
}
