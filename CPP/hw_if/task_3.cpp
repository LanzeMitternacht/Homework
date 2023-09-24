#include <iostream>
using namespace std;
int main()
{
    setlocale(LC_ALL, "rus");
    int un1, un2, un3, un4, un5, un6, un7, max;
    cout << "Введите cемь чисел\n";
    cin >> un1 >> un2 >> un3 >> un4 >> un5 >> un6 >> un7; 
    if (un1 > un2) {
        max = un1;
    }
    else {
        max = un2;
    }
    if (un3 > max) {
        max = un3;
    }
    else if (un4 > max) {
        max = un4;
    }
    else if (un5 > max) {
        max = un5;
    }
    else if (un6 > max) {
        max = un6;
    }
    else if (un7 > max) {
        max = un7;
    }
    cout << "Максимальное число: " << max;
    return 0;
}
