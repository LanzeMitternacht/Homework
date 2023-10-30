#include <iostream>
#include <time.h>
using namespace std;

int main() {
	srand(time(NULL));
	const int size = 10;
	int* arr;
	int* arr1;
	arr = new int[size];
	arr1 = new int[size];
	int number;
	for (int i = 0; i != size; i++) {
		number = rand() % 10;
		arr[i] = number;
		cout << arr[i] << " ";
	}
	cout << endl;
	for (int i = 0; i < size; i++) {
		arr1 = arr;
		cout << *arr1 << " ";
		arr1++;
		arr++;
	}
	cout << endl;
	return 0;
}
