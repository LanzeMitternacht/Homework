#include <iostream>
using namespace std;

int main()
{
    setlocale(LC_ALL, "rus");
    int a, b;
    cout << "Введите число а: ";
    cin >> a;
    cout << "Введите число b: ";
    cin >> b;
    for (int i = 1; i <= a && i <=b; i++) {
        if ((a % i == 0) && (b % i == 0)) {
            cout << i << endl;
        }
    }
    return 0;
}
