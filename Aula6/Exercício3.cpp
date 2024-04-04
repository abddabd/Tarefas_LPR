#include <iostream>

int main() {
    int soma = 0;

    for (int num = 50; num <= 500; ++num) {
        if ((num % 2 != 0) && (num % 3 == 0)) {
            soma += num;
        }
    }

    std::cout << "A soma dos números ímpares múltiplos de 3 é: " << soma << std::endl;

    return 0;
}
