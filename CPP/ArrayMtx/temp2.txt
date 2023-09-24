#include <iostream>
#define DEBUG

using namespace std;


int main() {

	srand(time(NULL));
	/*Создание матрицы массива mtx с размерами 4х4*/
	const int SIZE = 4;
	int mtx[SIZE][SIZE];

	/*Заполнение массива mtx*/
	for (int i = 0; i < SIZE; ++i) {
		for (int j = 0; j < SIZE; ++j) {
			mtx[i][j] = rand() % 10;
		}
	}
#ifdef DEBUG
	/*Просмотр массива mtx*/
	cout << "\tArray mtx" << endl;
	for (int i = 0; i < SIZE; ++i) {
		cout << "\n\t";
		for (int j = 0; j < SIZE; ++j) {
			cout << mtx[i][j] << " ";
		}
	}
	cout << endl;
#endif

	/*Создание массива result*/
	int result[SIZE] = {};

	/*Заполнение массива result массивом mtx*/
	for (int i = 0; i < SIZE; i++) {
		for (int j = 0; j < SIZE; j++) {
			result[j] += mtx[i][j];
		}
	}

#ifdef DEBUG
	/*Просмотр заполнения массива result*/
	cout << "\n\tResult: ";
	for (int i = 0; i < SIZE; i++) {
		cout << result[i] << " ";
	}
	cout << endl;
#endif

	return 0;
}


