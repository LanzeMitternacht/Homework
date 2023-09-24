#include <iostream>
#include <cassert>
#include <cstring>
using namespace std;

int my_strlen(const char* s) {
	int i = 0;
	while (s[i] != '\0')
		++i;

	return i;
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
	assert(my_strcmp("hi", "hi"));
	assert(my_strcmp("Hello", "Hello"));
	assert(my_strcmp("Hi", "hi"));
	return 0;
}
