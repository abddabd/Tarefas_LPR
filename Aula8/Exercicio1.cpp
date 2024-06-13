#include <iostream>
using namespace std;

int main()
{
    int nums[10];
    int evens[10];
    int odds[10];
    short nEven = 0;
    short nOdds = 0;
    
    for (short i = 0; i <= 9; i++) {
        cout << "Insira o " << i+1 << "o numero: ";
        cin >> nums[i];
        cout << endl;
    }
    for (short i = 0; i <= 9; i++) {
        if (nums[i] % 2 == 0) {
            evens[nEven] = nums[i];
            nEven++;
        } else {
            odds[nOdds] = nums[i];
            nOdds++;
        }
    }
    
    cout << "Pares: ";
    for (short i = 0; i < nEven; i++) {
        cout << evens[i] << endl;
    }
    cout << endl << "Impares: ";
    for (short i = 0; i < nOdds; i++) {
        cout << odds[i] << endl;
    }

    return 0;
}