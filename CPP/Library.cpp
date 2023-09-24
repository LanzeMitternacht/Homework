#include <iostream>
#include <cstring>
using namespace std;

struct Library {
	char publish[128];
	char autor[128];
	char book_name[128];
	void print() {
		cout << publish << " " << autor << " " << book_name << endl;
		for (int i = 1; i < 10; i++) {
			cout << i << ". Издатель:\t" << publish << "Автор:\t" << autor << "Название книги:\t" << book_name << endl;
		}
	}
	void write_book() {
		int q, q1;
		cout << "Какую книгу редактировать?\n";
		for (int i = 1; i < 10; i++) {
			cout << i << ". Издатель:\t" << publish << "Автор:\t" << autor << "Название книги:\t" << book_name << endl;
		}
		cin >> q;
		cout << "Что именно редактировать в книге?\n";
		cout << "1. Автора\n";
		cout << "2. Название\n";
		cout << "3. Издатель\n";
		cout << "4. Выход\n";
		cin >> q1;
		switch (q1)
		{
		case 1:
			cout << "Введите имя автора: ";
			cin >> autor;
			print();
			break;
		case 2:
			cout << "Введите название книги: ";
			cin >> book_name;
			print();
			break;
		case 3:
			cout << "Введите издательство: ";
			cin >> publish;
			print();
			break;
		default:
			cout << "Вы вышли из системы" << endl;
			break;
		}
	}
	void find_autor(const char* name) {
		if (strcmp(autor, name) == 0) {
			cout << "Издатель: " << publish << "Автор: " << autor << "Название книги: " << book_name << endl;
		}
		else {
			cout << "Автор не найден" << endl;
		}
	}

	void find_name(const char* name) {
		if (strcmp(book_name, name) == 0) {
			cout << "Издатель: " << publish << "Автор: " << autor << "Название книги: " << book_name << endl;
		}
		else {
			cout << "Название книги не найдено" << endl;
		}
	}

	void sort_name() {
		bool flag = true;
		do {
			for (int i = 0; i < sizeof(book_name); i++) {
				if (book_name[i] > book_name[i + 1]) {
					swap(book_name[i], book_name[i + 1]);
					flag = false;
				}
			}
		} while (!flag);
		for (int i = 0; i < sizeof(book_name); i++) {
			cout << i << ". Издатель:\t" << publish << "Автор:\t" << autor << "Название книги:\t" << book_name << endl;
		}
	}

	void sort_autor() {
		bool flag = true;
		do {
			for (int i = 0; i < sizeof(autor); i++) {
				if (autor[i] > autor[i + 1]) {
					swap(autor[i], autor[i + 1]);
					flag = false;
				}
			}
		} while (!flag);
		for (int i = 0; i < sizeof(autor); i++) {
			cout << i << ". Издатель:\t" << publish << "Автор:\t" << autor << "Название книги:\t" << book_name << endl;
		}
	}

	void sort_publish() {
		bool flag = true;
		do {
			for (int i = 0; i < sizeof(publish); i++) {
				if (publish[i] > publish[i + 1]) {
					swap(publish[i], publish[i + 1]);
					flag = false;
				}
			}
		} while (!flag);
		for (int i = 0; i < sizeof(publish); i++) {
			cout << i << ". Издатель:\t" << publish << "Автор:\t" << autor << "Название книги:\t" << book_name << endl;
		}
	}

}book;


void menu(int q) {
	string name_book;
	string name;
	switch (q)
	{
	case 1:
		book.write_book();
		break;
	case 2:
		book.print();
		break;
	case 3:
		cout << "Введите имя автора: ";
		cin >> name;
		book.find_autor(name.c_str());
		break;
	case 4:
		cout << "Введите название книги: ";
		cin >> name_book;
		book.find_name(name_book.c_str());
		break;
	case 5:
		book.sort_name();
		break;
	case 6:
		book.sort_autor();
		break;
	case 7:
		book.sort_publish();
		break;
	default:
		cout << "Вы вышли из системы" << endl;
		break;
	}
}

void question() {
	int q;
	cout << "\t\tМеню библиотеки:\n";
	cout << "\t1. Редактировать книгу" << endl;
	cout << "\t2. Печатать книги" << endl;
	cout << "\t3. Поиск книг по автору" << endl;
	cout << "\t4. Поиск книги по названию" << endl;
	cout << "\t5. Сортировать массив по названию книги" << endl;
	cout << "\t6. Сортировать массив по автору" << endl;
	cout << "\t7. Сортировать массив по издательству" << endl;
	cout << "\t8. Выход" << endl;
	cin >> q;
	menu(q);
}


int main() {
	setlocale(LC_ALL, "rus");
	Library book{ "MGY", "Alex", "Yesturday for night" };
	Library book_1{ "MGY", "Alex", "Horror mirror" };
	Library book_2{ "MGY", "Mihailov", "Today is over" };
	Library book_3{ "GiUrA", "Velkar", "War in your heart" };
	Library book_4{ "GiUrA", "Velkar", "Jeepers its end" };
	Library book_5{ "MGY", "Velkar", "All most in night" };
	Library book_6{ "Niura", "Lea", "Faruk and Erika" };
	Library book_7{ "Niura", "Lea","What is love?" };
	Library book_8{ "Niura", "Lea", "Lilith" };
	Library book_9{ "GiUrA", "Music info", "Your music" };
	Library book_10{ "GiUrA", "Music info", "History music" };
	question();
	return 0;
}
