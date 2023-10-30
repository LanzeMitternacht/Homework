#include <iostream>
using namespace std;
int main()
{
    setlocale(LC_ALL, "rus");
    int usernumber, a1, a2, a3, a4, c;
    cout << "Введите четырехзначное число\n";
    cin >> usernumber;
    if (usernumber / 1000 < 1) {
        cout << "Введеное число не четырехзначное\n";
    }
    else if (usernumber / 1000 > 9){
        cout << "Введеное число не четырехзначное\n";
    }
    else {
        a4 = usernumber % 10;
        c = usernumber / 10;
        a3 = c % 10;
        c = c / 10;
        a2 = c % 10;
        a1 = c / 10;
        cout << a1 << " " << a2 << " " << a3 << " " << a4 << "\n";
        c = a1;
        a1 = a2;
        a2 = c;
        c = a3;
        a3 = a4;
        a4 = c;
        cout << a1 << " " << a2 << " " << a3 << " " << a4;
    }
    return 0;
}
