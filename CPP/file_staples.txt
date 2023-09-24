#include <iostream>
#include <fstream>
#include <stack>
#include <string>

using namespace std;

bool is_valid(string& path) {
	ifstream ifs(path);
	if (ifs.is_open()) {
		stack<char> stk;
		char chl, chr;
		while (ifs >> chr) {
			if (chr == '(' || chr == '[' || chr == '{') {
				stk.push(chr);
			} 
			else if (chr == ')' || chr == ']' || chr == '}') {
				if (stk.empty()) {
					return false;
				} 
				else {
					chl = stk.top();
					stk.pop();
					if (chr == ')' && chl != '(' || chr == ']' && chl != '[' || chr == '}' && chl != '{') {
						return false;
					}
				}
			}
		}
		return stk.empty();
	}
	else {
		return false;
	}
}

int main(){
	string filet = "filetrue.txt";
	bool result = is_valid(filet);
	cout << (result ? "true" : "false") << endl;
	string filef = "filefalse.txt";
	result = is_valid(filef);
	cout << (result ? "true" : "false") << endl;

}
