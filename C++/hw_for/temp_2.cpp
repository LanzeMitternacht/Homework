#include<iostream>
using namespace std;

int main() {
	setlocale(LC_ALL, "rus");
	int a = 100, b = 999, c, n1, n2, n3, temp, how = 0;
	for (int i = a; i < b; i++) {
		c = 0;
		n3 = i % 10;
		temp = i / 10;
		n2 = temp % 10;
		n1 = temp / 10;
		if ((n1 != n2) && (n1 != n3) && (n2 != n3)) {
			c++;
		}
		else if ((n2 != n3) && (n2 != n1) && (n3 != n1)) {
			c++;
		}
		else if ((n1 != n3) && (n1 != n2) && (n3 != n2)) {
			c++;
			}
		if (c == 1) {
			how++;
		}
	}
	cout << "Чисел с одинаковыми цифрами: " << how << endl;
	return 0;
}
