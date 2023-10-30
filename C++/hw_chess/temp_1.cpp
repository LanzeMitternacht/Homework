#include <iostream>
using namespace std;
int main()
{
    setlocale(LC_ALL, "rus");
    int a, user, arif = 0, temp = 0, chis = 0, sum = 0, ztemp = 0;
    cout << "Введите целое число а: ";
    cin >> a;
    do
    {
        cout << "Меню выбора оператора:\n";
        cout << "1 - Сумма чисел\n";
        cout << "2 - Сколько цифр в вашем числе\n";
        cout << "3 - Среднее арефметическое вашего числа\n";
        cout << "4 - Количество нулей в вашем числе\n";
        cout << "5 - Выход\n";
        cin >> user;
        while (a > 0) {
            temp = a % 10;
            sum += temp;
            chis++;
            a = a / 10;
            arif = sum / chis;
            if (temp == 0) {
                ztemp++;
            }
        }
        switch (user)
        {
        case 1:
        {
            cout << "Сумма чисел равна " << sum << endl;
            break;
        }
        case 2:
        {
            cout << "В вашем числе " << chis << " цифр(-ы)\n";
            break;
        }
        case 3:
        {
            cout << "Среднее арифметическое числа равена " << arif << endl;
            break;
        }
        case 4:
        {
            cout << "Количество нулей в вашем числе равна: " << ztemp << endl;
            break;
        }
        case 5:
        {
            cout << "Вы вышли из программы\n";
            break;
        }
        default:
            cout << "Неккоректный запрос\n";
        }
    } while (user != 5);
    return 0;
}
