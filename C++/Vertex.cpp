#include <iostream>
#include <string>
#include <ctime>


using namespace std;
#if 0
struct Country {
	enum type {
		Russia,
		USA,
		Germany,
		Japany,
	};
	type t;

	operator const char* () {
		switch (t) {
		case Russia: return "Russia";
		case USA: return "USA";
		case Germany: return "Germany";
		case Japany: return "Japany";
		default: return "";
		}
	}
};
using country_t = Country::type;

//string dateTime() {
//	time_t t = time(nullptr);
//	tm* now = localtime(&t);
//
//	char buffer[128];
//	strftime(buffer, sizeof(buffer), "%m-%d-%Y %X", now);
//	return buffer;
//}

//void dateTime() {
//	time_t t = time(0);
//	tm* now = localtime(&t);
//
//	cout << 1 + now->tm_mday << "." << 1 + now->tm_mon << "." << 1970 + now->tm_year
//		<< " " << 1 + now->tm_hour << ":" << 1 + now->tm_min << ":" << 1 + now->tm_sec;
//}

class Buyer {
protected:
	string m_name;
	string m_birthday;
	string m_number;
	int m_indexMail;
	Country m_country;
	string m_region;
	string m_address;
	string m_time;
	int m_purchaseSum;
public:
	void setName(string name_s) {
		m_name = name_s;
	}
	string name() const {
		return m_name;
	}

	void setBirthday(string dd_mm_yy) {
		m_birthday = dd_mm_yy;
	}
	string birthday() const {
		return m_birthday;
	}
	
	void setPhoneNumber(string phoneNumber) {
		m_number = phoneNumber;
	}
	void phoneNumber() {
		for (int i = 0; i < 2; ++i) {
			cout << m_number[i];
		}
		cout << " (";
		for (int i = 2; i < 5; ++i) {
			cout << m_number[i];
		}
		cout << ") ";
		for (int i = 5; i < 8; ++i) {
			cout << m_number[i];
		}
		cout << " ";
		for (int i = 8; i < 10; ++i) {
			cout << m_number[i];
		}
		cout << "-";
		for (int i = 10; i < 13; ++i) {
			cout << m_number[i];
		}
		cout << endl;
	}

	void setIndexMail(int indexMail) {
		m_indexMail = indexMail;
	}
	int indexMail() const {
		return m_indexMail;
	}

	void setCountry(country_t country) {
		m_country = Country{ country };
	}
	Country country() const {
		return m_country;
	}

	void setRegion(string region) {
		m_region = region;
	}
	string region() const {
		return m_region;
	}

	void setAddress(string address) {
		m_address = address;
	}
	string address() const {
		return m_address;
	}

	void setTime(string time_s) {
		m_time = time_s;
	}
	string time() const {
		return m_time;
	}
	
	void setPurchaseSum(int purchSum) {
		m_purchaseSum = purchSum;
	}
	int purchaseSum() const {
		return m_purchaseSum;
	}

	void print() {
		cout << "Full name:\t\t\t" << m_name << endl;
		cout << "Birthday:\t\t\t" << m_birthday << endl;
		cout << "Phone number:\t\t\t"; phoneNumber();
		cout << "Mail index:\t\t\t" << m_indexMail << endl;
		cout << "Country:\t\t\t" << m_country << endl;
		cout << "Region:\t\t\t\t" << m_region << endl;
		cout << "Address:\t\t\t" << m_address << endl;
		cout << "Date registration:\t\t" << m_time << endl;
		cout << "Total amount of all purchases:\t" << m_purchaseSum << " rub" << endl;
	}

};


int main() {
	Buyer guy;
	guy.setName("Palochnikov Vladimir Nickolaevich");
	guy.setBirthday("12.02.1999");
	guy.setPhoneNumber("+79914342452");
	guy.setIndexMail(682945);
	guy.setCountry(country_t::Russia);
	guy.setRegion("Vologda");
	guy.setAddress("Alexandra Street house 14/1");
	guy.setTime("12.05.2023 23:44");
	guy.setPurchaseSum(135000);
	guy.print();
	return 0;
}

#endif

class TwoPoint {
public:
	TwoPoint(double x = 0.0, double y = 0.0) : m_x(x), m_y(y) {}
	void setX(double x) {
		m_x = x;
	}
	void setY(double y) { 
		m_y = y; 
	}
	double getX() const {
		return m_x;
	}
	double getY() const {
		return m_y;
	}
protected:
	double m_x;
	double m_y;
};


class Triangle {
protected:
	TwoPoint* m_vertexA;
	TwoPoint* m_vertexB;
	TwoPoint* m_vertexC;
public:
	enum Vertex { vertexA, vertexB, vertexC };
	Triangle(): m_vertexA(new TwoPoint), m_vertexB(new TwoPoint), m_vertexC(new TwoPoint){}

	Triangle(const TwoPoint& vertexA, const TwoPoint& vertexB, const TwoPoint& vertexC): m_vertexA(new TwoPoint(vertexA)),m_vertexB(new TwoPoint(vertexB)),m_vertexC(new TwoPoint(vertexC)){}

	Triangle(const Triangle& other): m_vertexA(new TwoPoint(*(other.m_vertexA))),m_vertexB(new TwoPoint(*(other.m_vertexB))),m_vertexC(new TwoPoint(*(other.m_vertexC))){}

	Triangle(Triangle&& other): m_vertexA(other.m_vertexA),m_vertexB(other.m_vertexB),m_vertexC(other.m_vertexC){
		other.m_vertexA = nullptr;
		other.m_vertexB = nullptr;
		other.m_vertexC = nullptr;
	}

	~Triangle(){
		delete m_vertexA;
		delete m_vertexB;
		delete m_vertexC;
		m_vertexA = nullptr;
		m_vertexB = nullptr;
		m_vertexC = nullptr;
	}

	void setVertex(Vertex vertex, const TwoPoint& point){
		switch (vertex)
		{
		case vertexA:
			*(m_vertexA) = point;
			break;
		case vertexB:
			*(m_vertexB) = point;
			break;
		case vertexC:
			*(m_vertexC) = point;
			break;
		}
	}

	const TwoPoint& getVertex(Vertex vertex) const{
		switch (vertex)
		{
		case vertexA:
			return *(m_vertexA);
		case vertexB:
			return *(m_vertexB);
		case vertexC:
			return *(m_vertexC);
		}
	}

	double getSideLength(Vertex vertex1, Vertex vertex2) const{
		const TwoPoint& point1 = getVertex(vertex1);
		const TwoPoint& point2 = getVertex(vertex2);
		return sqrt(pow(point1.getX() - point2.getX(), 2) + pow(point1.getY() - point2.getY(), 2));
	}

	double getPerimeter() const{
		return getSideLength(vertexA, vertexB) + getSideLength(vertexB, vertexC) + getSideLength(vertexC, vertexA);
	}

	double getSquare() const{
		double a = getSideLength(vertexA, vertexB);
		double b = getSideLength(vertexB, vertexC);
		double c = getSideLength(vertexC, vertexA);
		double s = (a + b + c) / 2;
		return sqrt(s * (s - a) * (s - b) * (s - c));
	}
};



int main() {
	setlocale(LC_ALL, "rus");


	Triangle ter(23,41,54);
	TwoPoint pointA;
	pointA.setX(24.5);
	pointA.setY(25.5);

	TwoPoint pointB;
	pointB.setX(28.3);
	pointB.setX(29.4);

	TwoPoint pointC;
	pointC.setX(15.3);
	pointC.setX(13.0);
	ter.setVertex(ter.vertexA, pointA);
	ter.setVertex(ter.vertexB, pointB);
	ter.setVertex(ter.vertexC, pointC);

	cout << "Площадь треугольника: " << ter.getSquare() << endl;
	cout << "Периметр треугольника: " << ter.getPerimeter() << endl;
	cout << "Длина стороны A и B: " << ter.getSideLength(ter.vertexA, ter.vertexB) << endl;
	cout << "Длина стороны A и C: " << ter.getSideLength(ter.vertexA, ter.vertexC) << endl;
	cout << "Длина стороны B и C: " << ter.getSideLength(ter.vertexB, ter.vertexC) << endl;
	return 0;
}




