#include <iostream>
#include <time.h>
using namespace std;

int main() {
	srand(time(NULL));
	int size = 10;
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
		arr1[i] = arr[i];
		swap(arr[i], arr1[size - i]);
		cout << *arr1 << " ";
		arr++;
		arr1++;
		
	}
	cout << endl;
	return 0;
}
