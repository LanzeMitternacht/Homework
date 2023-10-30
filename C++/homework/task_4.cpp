#include <iostream>
using namespace std;


int main()
{
	setlocale(LC_ALL, "rus");
	int a;
	long x = 1;
	cout << "Введите число а: ";
	cin >> a;
	while (a < 1 || a > 20) {
		cout << "Вы ввели некоректное число а\n";
		cout << "Повторите ввод числа а: ";
		cin >> a;
	}
	for (int i = a; i <= 20; i++) {
		x *= i;
		cout << x << endl;
	}
	return 0;
}
 
