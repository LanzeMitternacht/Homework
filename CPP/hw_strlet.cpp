#include <iostream>
#include <cstring>
using namespace std;

void count(const char* s) {
	int other = 0;
	int letters = 0;
	int number = 0;
	int i = 0;
	while (s[i] != '\0') {
			if ((s[i] >= 'а') && (s[i] <= 'я') || (s[i]>='А') &&(s[i] <= 'Я') || (s[i] >= 'a') && (s[i] <= 'z') || (s[i] >= 'A') && (s[i] <= 'Z')) {
				++letters;
				++i;
			}
			else if (s[i] >= '0' && s[i] <= '9') {
				++number;
				++i;
			}
			else if(s[i] == ' '){
				++other;
				++i;
			}
	}
	cout << "Other " << other << "\nLetters " << letters << "\nNumber " << number << endl;
}


int main() {
	setlocale(LC_ALL, "rus");
	char eng[128]{ "Two plus two its 4" };
	char rus[128]{ "Дважды два 4" };
	cout << "ENG:\n";
	count(eng);
	cout << "RUS:\n";
	count(rus);
	return 0;
}
