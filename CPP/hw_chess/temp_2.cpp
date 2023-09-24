#include <iostream>
using namespace std;
int main()
{
	setlocale(LC_ALL, "rus");
	int cellSize;
	cout << "Размер ячеек: ";
	cin >> cellSize;
	for (int i = 0; i < 8; i++)
	{
		if (i % 2 == 0)
		{
			for (int k = 0; k < cellSize; k++)
			{
				for (int j = 0; j < 8; j++)
				{
					if (j % 2 == 0)
					{
						for (int l = 0; l < cellSize; l++)
						{
							cout << "*";
						}
					}
					else
					{
						for (int l = 0; l < cellSize; l++)
						{
							cout << " ";
						}
					}
				}
				cout << "\n";
			}
		}
		else {
			for (int k = 0; k < cellSize; k++)
			{
				for (int j = 0; j < 8; j++)
				{
					if (j % 2 == 0)
					{
						for (int l = 0; l < cellSize; l++)
						{
							cout << " ";
						}
					}
					else
					{
						for (int l = 0; l < cellSize; l++)
						{
							cout << "*";
						}
					}
				}
				cout << "\n";
			}
		}
	}
	return 0;
}
