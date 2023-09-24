#include <iostream>
#include <stdlib.h>
#include <vector>
#define DEBUG

using namespace std;

/*Решение с использованием массива mtx и result*/
#if 0
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

	/*Просмотр массива mtx*/
#ifdef DEBUG
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
	int count = 0;
	int result[SIZE * SIZE];

	/*Сортировка белых элементов*/
	for (int i = 0; i < SIZE; ++i) {
		for (int j = 0; j < SIZE; ++j) {
			if ((i + j) % 2 == 0) {
				result[count] = mtx[i][j];
				count++;
			}
		}
	}

	/*Сортировка черных элементов*/
	for (int i = 0; i < SIZE; ++i) {
		for (int j = 0; j < SIZE; ++j) {
			if ((i + j) % 2 == 1) {
				result[count] = mtx[i][j];
				count++;
			}
		}
	}

	/*Выводим массив в консоль*/
	cout << "\n\tResult: ";
	for (int i = 0; i < (SIZE * SIZE); ++i) {
		cout << result[i] << " ";
	}
	cout << endl;

    return 0;
}
#endif


/*Решение с использованием векторов*/
#if 0
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
	/*Создание 3х векторов и заполнение массивом mtx с помощью фильтрации*/
	vector<int> white;
	vector<int> black;
	vector<int> resultvector;

	for (int i = 0; i < SIZE; ++i) {
		for (int j = 0; j < SIZE; ++j) {
			if (j % 2 != 0) {
				white.push_back(mtx[i][j]);
			}
			else {
				black.push_back(mtx[i][j]);
			}
		}
	}

	/*Изменение размера ветора wb и копирование в него инфомрацию из векторов white и black*/
	resultvector.resize(white.size() + black.size());
	copy(white.begin(), white.end(), resultvector.begin());
	copy(black.begin(), black.end(), resultvector.begin() + white.size());

	/*Вывод векторов в консоль*/
	cout << "\n\tResult vector: ";
	for (int i = 0; i < resultvector.size(); ++i) {
		cout << resultvector[i] << " ";
	}
	cout << "\n\tWhite: ";
	for (int i = 0; i < white.size(); ++i) {
		cout << white[i] << " ";
	}
	cout << "\n\tBlack: ";
	for (int i = 0; i < black.size(); ++i) {
		cout << black[i] << " ";
	}
	cout << endl;

	return 0;
}
#endif

