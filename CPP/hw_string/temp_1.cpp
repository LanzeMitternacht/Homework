#include <iostream>
#include <cassert>
using namespace std;
//#define DEBUG

int my_strlen(const char* s) {
	int i = 0;
	while (s[i] != '\0')
		++i;

	return i;
}

int main() {
#ifdef DEBUG
	cout << my_strlen("hello") << endl;
#endif
	assert(strlen("hello") == 5);
	assert(strlen("hallomeinefruend") != 5);
	return 0;
}
