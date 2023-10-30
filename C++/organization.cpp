#include <iostream>
#include <string>
#include <vector>
#include <list>

using namespace std;


class Auditoriums {
	int m_monitors;
	int m_tables;
	int m_chairs;
	int m_hangers;
	int m_projectors;
public:
	Auditoriums(int monitor, int table, int chair, int hanger, int projector) :m_monitors(monitor), m_tables(table), m_chairs(chair), m_hangers(hanger), m_projectors(projector) {}

	void setMonitor(int number) {
		m_monitors = number;
	}
	int monitors() const {
		return m_monitors;
	}

	void setTable(int number) {
		m_tables = number;
	}
	int table() const {
		return m_tables;
	}

	void setChair(int number) {
		m_chairs = number;
	}
	int chair() const {
		return m_chairs;
	}

	void setHanger(int number) {
		m_hangers = number;
	}
	int hanger() const {
		return m_hangers;
	}

	void setProjector(int number) {
		m_projectors = number;
	}
	int projector() const {
		return m_projectors;
	}

	void print() const {
		cout << "Monitors: " << m_monitors << endl;
		cout << "Tables: " << m_tables << endl;
		cout << "Chairs: " << m_chairs << endl;
		cout << "Hangers: " << m_hangers << endl;
		cout << "Projectors: " << m_projectors << endl;
	}
};


class Organization {
	string m_phoneNumber;
	string m_address;
	list<Auditoriums> m_auditorium;
public:
	Organization(string pNumber, string address, Auditoriums& auditorium) : m_phoneNumber(pNumber), m_address(address){
		m_auditorium.push_back(auditorium);
	}

	void setAuditorium(Auditoriums& audi) {
		m_auditorium.push_back(audi);
	}

	void setAddress(string address) {
		m_address = address;
	}

	void setPhoneNumber(string phoneNumber) {
		m_phoneNumber = phoneNumber;
	}

	void printReport() const {
		cout << "Phone: " << m_phoneNumber << endl;
		cout << "Address: " << m_address << endl;
		for (const auto& auditorium : m_auditorium) {
			auditorium.print();
			cout << endl;
		}
	}
};


int main() {
	Auditoriums first(1, 2, 3, 4, 5);
	Auditoriums second(2, 3, 4, 5, 6);
	Auditoriums third(12, 32, 45, 12, 1);
	Organization ff("235-235", "Hamburg", first);
	ff.setAuditorium(second);
	ff.setAuditorium(third);
	first.print();
	cout << endl;
	ff.printReport();
	return 0;
}
