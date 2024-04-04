#include <iostream>

int main() {
    int quant;
    std::cout << "Digite a quantidade de números: ";
    std::cin >> quant;

    int soma = 0;
    int pares = 0;
    int i = 0;

    while (i < quant) {
        
        int numero;
        std::cout << "Digite o número " << i + 1 << ": ";
        std::cin >> numero;

        if (numero % 2 == 0) {
            soma += numero;
            pares++;
        }

        i++;
    }

        double med = static_cast<double>(soma) / static_cast<double>(pares);
        std::cout << "A média dos números pares é " << med << std::endl;
    
    return 0;
}
