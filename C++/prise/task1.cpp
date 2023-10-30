#include <iostream>
using namespace std;


int main()
{
	setlocale(LC_ALL, "rus");
	int id_piz, id_cup, how_piz, how_cup, five;
	float piz1, piz2, piz3, cup1, cup2, cup3, selpiz, selcup, sumprise;
	piz1 = 5.34; piz2 = 22.23; piz3 = 8.5;
	cup1 = 3.03; cup2 = 1.23; cup3 = 2.4;
	sumprise = 0;
	cout << "\t\tВведите номер желаемой приццы\n";
	cout << "Номер\t  Вид пиццы\t   Цена\n";
	cout << "123\tПицца с пеперони   " << piz1 << "\n";
	cout << "321\tПицца с сыром\t   " << piz2 << "\n";
	cout << "456\tПицца с грибами\t   " << piz3 << "\n";
	cin >> id_piz;
	cout << "Введите количество пиццы: ";
	cin >> how_piz;
	cout << "\n";
	cout << "\t\tВыберете напинок\n";
	cout << "Номер\tНапиток   Цена\n";
	cout << "45\tФанта\t  " << cup1 << "\n";
	cout << "25\tСпрайт\t  " << cup2 << "\n";
	cout << "14\tКола\t  " << cup3 << "\n";
	cin >> id_cup;
	cout << "Введите количество напитков: ";
	cin >> how_cup;

	switch (id_piz) {
	case 123:
		selpiz = piz1;
		break;
	case 321:
		selpiz = piz2;
		break;
	case 456:
		selpiz = piz3;
		break;
	default:
		cout << "Такой пиццы у нас нету\n";
		selpiz = 0;
		break;
	}

	switch (id_cup) {
	case 45:
		selcup = cup1;
		break;
	case 25:
		selcup = cup2;
		break;
	case 14: 
		selcup = cup3;
		break;
	default:
		cout << "Такого напитка у нас нету\n";
		selcup = 0;
		break;
	}

	five = how_piz;
	if (how_piz >= 5) {
		cout << "Пятая пицца в подарок\n";
		how_piz = how_piz - how_piz / 5;
	}
	sumprise = sumprise + how_piz * selpiz;
	if ((how_cup >= 3) && (selcup > 2)) {
		cout << "У вас скидка 15% на напитки\n";
		sumprise = sumprise + how_cup * selcup * (1 - 0.15);
	}
	else {
		sumprise = sumprise + how_cup * selcup;
	}
	if (sumprise > 50) {
		cout << "У вас скидка 20%\n";
		sumprise = sumprise * (1 - 0.2);
	}
	cout << "Ваш заказ: \n";
	cout << "Пицца " << id_piz << " " << five << selpiz << "$\n";
	cout << "Напитки " << id_cup << " " << how_cup << selcup << "$\n";
	cout << "Цена: " << sumprise << "$\n";
	return 0;
}
 
