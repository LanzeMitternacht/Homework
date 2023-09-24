#include <iostream>
#include <cassert>
#include <cstring>
//#define DEBUG
using namespace std;

int my_strlen(const char* s) {
	int i = 0;
	while (s[i] != '\0')
		++i;

	return i;
}

char* my_strcpy(char* dest, const char* source) {
	int i = 0;
	while (source[i] != '\0') {
		dest[i] = source[i];
		++i;
	}
	dest[i] = '\0';

	return dest;
}

bool my_strcmp(const char * str1, const char* str2){
	if (my_strlen(str1) == my_strlen(str2)) {
		for (int i = 0; i < strlen(str1); i++) {
			if (str1[i] == str2[i]) {
				return true;
			}
			else {
				return false;
			}
		}
	}
	else {
		return false;
	}
	
}

int main() {
	char str[128];
	my_strcpy(str, "Hello");
	assert(my_strcmp(str, "Hello"));
#ifdef DEBUG
	cout << str << " - " << strlen(str) << endl << "Hello - " << strlen("Hello") << endl;
#endif
	return 0;
}
