#include <iostream>
#include <string>
#include <regex>

using namespace std;
/*Проверка на валидность имени*/
void isValid_Name(string &name) {
	if (name.empty()) {
		throw "Not valid name";
	}
}
/*Проверка на валидность возраста*/
void isValid_Age(unsigned int &age) {
	if (age <= 14 || age >= 110) {
		throw "Not valid age";
	}
}
/*Проверка на валидность адреса*/
void isValid_Address(string& address) {
	if (address.empty()) {
		throw "Not valid address";
	}
}
/*Проверка на валидность номер телефона*/
bool isValid_PhoneNumber(string &str) {
	const regex phone_number{ "^(\\+7|8)(\\d{10})$" }; //Создание шаблона номера телефона +7/80000000000
	if (regex_match(str, phone_number)) { return true; }
	else {
		throw "Not valid phone number";
		return false;
	}
}
/*Проверка на валидность баланс*/
void isValid_Balance(int& balance) {
	if (balance < 0) {
		throw "Not valid balance";
	}
}
/*Смена регистра в string*/
void caseСhange(string& str) {
	for (auto& c : str) {
		c = tolower(c); // Все элементы в str меняются на нижний регистр
	}
	str[0] = toupper(str[0]); // Первый элемент в str меняется на верхний регистр
}
/*Класс User*/
class User {
	string m_name;
	unsigned int m_age;
	string m_address;
	string m_phoneNumber;
	int m_balance;
	User(string name, int age, string address, string phoneNumber, int balance):m_name(name),m_age(age),m_address(address),m_phoneNumber(phoneNumber),m_balance(balance){}
public:
	static User create(string name, unsigned int age, string address, string phoneNumber, int balance) { // Функция создающая класс User, если пройдет проверку
		try { // Проверка валидности вводиным данных
			isValid_Name(name);
			isValid_Age(age);
			isValid_Address(address);
			isValid_PhoneNumber(phoneNumber);
			isValid_Balance(balance);
		}
		catch (const char* error_message) { // Захват вызова исключения из функций валидности
			cout << error_message << endl;
			terminate(); // Вывод сообщение об ошибке и экстренное завершение программы
		}
		return User(name, age, address, phoneNumber, balance); // Возращает элементы в конструктор User
	}
	/*Вывод класс User на экран*/
	void print() const {
		cout << "\nName: " << m_name << "\nAge: " << m_age << "\nAddress: " << m_address << "\nPhone number: " << m_phoneNumber << "\nBalance: " << m_balance << endl;
	}
	/*Создание string, который содержит в себе несколько классов User*/
	string makeReport(User& u, string &str) {
		str.append("Name: ").append(u.m_name).append("\nPhone number: ").append(u.m_phoneNumber);
		str.append("\nBalance: ").append(to_string(u.m_balance)).append("\n\n");

		return str;
	}
	/*Суммирует баланс User*/
	void accrualMoney(unsigned int money) {
		m_balance += money;
	}
	/*Вычитает баланс User*/
	void withdrawalMoney(unsigned int money) {
		m_balance -= money;
	}
	/*Изменение имени*/
	void changeName(string name) {
		if (name.empty() || name.size() <= 1) { // Проверка имени на пустоту и короткое ли имя
			cout << "\nName can't will empty or of one letter. Try again.\n";
			return;
		}
		int checkup = isupper(name[0]); // Проверка первого элемента имени на верхний регистр
		int check;
		for (int i = 0; i < name.size(); ++i) { 
			check = isalpha(name[i]); // Проверка имени на пробелы и знаки препинания
			if (!check) {
				cout << "\nName can't contain space and punctuation marks. Try again.\n";
				return;
			}
		}
		for (int i = 0; i < name.size(); ++i) {
			check = isdigit(name[i]); // Проверка имени на цифры
			if (check) {
				cout << "\nName can't contain numbers. Try again.\n";
				return;
			}
		}
		for (int i = 1; i < name.size(); ++i) {
			check = islower(name[i]); // Проверка имени на нижний регистр
			if (check || checkup) {
				caseСhange(name); // Изменение регистров в имени
				m_name = name;
				return;
			}
		}
	}
	/*Смена адреса проживания*/
	void changeAddress(string address) {
		if (address.empty()) { // Проверка адреса на пустоту
			cout << "\nAddress can't will empty. Try again.\n";
		}
		else {
			m_address = address;
		}
	}
	/*Смена номера телефона*/
	void changePhoneNumber(string number)  {
		try {
			if (isValid_PhoneNumber(number)) { // Проверка номера на валидность
				m_phoneNumber = number;
			}
		}
		catch (const char* error_message) {  // Захват вызова исключения из функций валидности
			cout << error_message << endl;	
		}	
	}
};
/*Вывод массива классов User на экран*/
void report(string& str) {
	for (int i = 0; i < str.size(); ++i) {
		cout << str[i];
	}
	cout << endl;
}

int main() {
	
	User u = User::create("Mark", 18, "Yagorewka", "+79982345678", 0);
	User p = User::create("Max", 21, "Krasnodar", "+79872355898", 15000);
	User i = User::create("Alex", 58, "Moscow", "89992567678", 1000000);
	User s = User::create("Erika", 27, "Germany", "+79982349567", 0);
	u.withdrawalMoney(150);
	s.accrualMoney(150);
	s.accrualMoney(2643);
	s.changeAddress("Germany, Humburg");
	s.changeName("EriKa");
	s.changePhoneNumber("79982349567");
	string strreport = {};
	strreport = u.makeReport(u, strreport);
	strreport = p.makeReport(p, strreport);
	strreport = i.makeReport(i, strreport);
	strreport = s.makeReport(s, strreport);
	report(strreport);
	s.print();
	return 0;
}


