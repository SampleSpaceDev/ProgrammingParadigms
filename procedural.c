#include "stdbool.h"
#include "stdio.h"

bool isPrimeR(int number, int divisor) {
    if (number <= 1) {
        return false;
    }
    if (divisor == number) {
        return true;
    }
    if (number % divisor == 0) {
        return false;
    }
    return isPrimeR(number, divisor + 1);
}

bool isPrime(int number) {
    return isPrimeR(number, 2);
}

int main(void) {
    int num = 10;
    bool result = isPrime(num);
    printf("Number %i - is Prime? (0 = false, 1 = true) %i\n", num, result);
}