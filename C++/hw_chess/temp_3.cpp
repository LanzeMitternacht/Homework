#include <iostream>
using namespace std;
int main()
{
	setlocale(LC_ALL, "rus");
	int a, b = 0, c;
	int blin = 12, pech = 10, cof = 5, tea = 5;
	double sum = 0, summ = 0, pblin = 1.24, ppech = 1.55, pcof = 0.85, ptea = 0.24;
	do {
		cout << "Меню кафетерия:\n";
		cout << "1 - Блины со сгущенкой - 1.24$" << " - " << blin << endl;
		cout << "2 - Печенье шоколадное - 1.55$" << " - " << pech << endl;
		cout << "3 - Кофе - 0.85$" << " - " << cof << endl;
		cout << "4 - Чай - 0.24$" << " - " << tea << endl;
		cout << "5 - Вывести чек\n";
		while (true) {
			cout << "Выберите продукт\n";
			cin >> a;
			switch (a)
			{
			case 1:
				cout << "Выбран товар: Блины со сгущенкой\n";
				cout << "Введите количество товара: ";
				cin >> b;
				blin = blin - b;
				if (blin <= 0) {
					cout << "Блинов больше не осталось.\n";
					break;
				}
				sum = sum + pblin * b;
				summ = summ + sum;
				break;
			case 2:

				cout << "Выбран товар: Печенье шоколадное\n";
				cout << "Введите количество товара: ";
				cin >> b;
				pech = pech - b;
				if (pech <= 0) {
					cout << "Печенья больше не осталось.\n";
					break;
				}
				sum = sum + ppech * b;
				summ = summ + sum;
				break;
			case 3:

				cout << "Выбран товар: Кофе\n";
				cout << "Введите количество товара: ";
				cin >> b;
				cof = cof - b;
				if (cof <= 0) {
					cout << "Кофе больше не осталось.\n";
					break;
				}
				sum = sum + pcof * b;
				summ = summ + sum;
				break;
			case 4:
				cout << "Выбран товар: Чай\n";
				cout << "Введите количество товара: ";
				cin >> b;
				tea = tea - b;
				if (tea <= 0) {
					cout << "Чая больше не осталось.\n";
					break;
				}
				sum = sum + ptea * b;
				summ = summ + sum;
				break;
			case 5:
				cout << "Цена заказа: " << sum << "$" << endl;
				cout << "Имеются ли ещё клиенты? 1 - Да. 2 - Нет\n";
				cin >> c;
				if (c == 2) {
					cout << "Сегодняшная выручка составила: " << summ << "$";
					return 0;
				}
				else if (c == 1) {
					sum = 0;
					cout << "Меню кафетерия:\n";
					cout << "1 - Блины со сгущенкой - 1.24$" << " - " << blin << endl;
					cout << "2 - Печенье шоколадное - 1.55$" << " - " << pech << endl;
					cout << "3 - Кофе - 0.85$" << " - " << cof << endl;
					cout << "4 - Чай - 0.24$" << " - " << tea << endl;
					cout << "5 - Вывести чек\n";
					break;
				}
			default:
				cout << "Неккоректный запрос\n";
				break;
			}
		}
	} while (a != 5);
	
	return 0;
}
