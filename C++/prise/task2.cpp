#include <iostream>
using namespace std;


int main()
{
	setlocale(LC_ALL, "rus");
	int meneg1, meneg2, meneg3, bestmeneg, first;
	float salar1, salar2, salar3;
	cout << "Введите уровень продаж первого менеджера: ";
	cin >> meneg1;
	cout << "Введите уровень продаж второго менеджера: ";
	cin >> meneg2;
	cout << "Введиет уровень продаж третьего менеджера: ";
	cin >> meneg3;
	if (meneg1 < 500) {
		salar1 = 200 + meneg1 * 0.003;
	}
	else if ((meneg1 >= 500) && (meneg1 < 1000)) {
		salar1 = 200+meneg1*0.005;
	}
	else {
		salar1 = 200 + meneg1 * 0.008;
	}
	if (meneg2 < 500) {
		salar2 = 200 + meneg2 * 0.003;
	}
	else if ((meneg2 >= 500) && (meneg2 < 1000)) {
		salar2 = 200 + meneg2 * 0.005;
	}
	else {
		salar2 = 200 + meneg2 * 0.008;
	}
	if (meneg3 < 500) {
		salar3 = 200 + meneg3 * 0.003;
	}
	else if ((meneg3 >= 500) && (meneg3 < 1000)) {
		salar3 = 200 + meneg3 * 0.005;
	}
	else {
		salar3 = 200 + meneg3 * 0.008;
	}
	if (meneg1 > meneg2) {
		bestmeneg = 1;
		first = meneg1;
	}
	else {
		bestmeneg = 2;
		first = meneg2;
	} 
	if (meneg3 > first) {
		bestmeneg = 3;
	}
	switch (bestmeneg) {
	case 1:
		salar1 = salar1 + 200;
		break;
	case 2:
		salar2 = salar2 + 200;
		break;
	case 3:
		salar3 = salar3 + 200;
		break;
	}
	cout << "Лучший менеджер: " << bestmeneg << "\n";
	cout << "Зарплата у первого менеджера: " << salar1 << "\n";
	cout << "Зарплата у второго менеджера: " << salar2 << "\n";
	cout << "Зарплата у третьего менеджера: " << salar3 << "\n";
	return 0;
}
