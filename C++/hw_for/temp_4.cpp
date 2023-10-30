#include<iostream>
using namespace std;

int main() {
	setlocale(LC_ALL, "rus");
	int a, b = 0;
	cout << "Введите число а: ";
	cin >> a;
	for (int i = a - 1; i > 1; i--) {
		b = i;
		if ((a % (b * b) == 0) && (a % (b * b * b) != 0)) {
			cout << b << endl;
		}
	}
	return 0;
}
