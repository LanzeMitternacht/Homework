#include <iostream>
#include <map>
#include <string>
#include <exception>
using namespace std;


int romanToInt(string number){
    if (number.length() >= 1 && number.length() <= 15) {
        int num = 0;
        map<char, int> rim{
            { 'I',1 },
            { 'V',5 },
            { 'X',10 },
            { 'L',50 },
            { 'C',100 },
            { 'D',500 },
            { 'M',1000 }
        };
        int result = 0;
        for (int i = 0; i < number.length(); i++) {
            if (i < number.length() - 1 && rim[number[i]] < rim[number[i + 1]]) {
                result -= rim[number[i]];
            }
            else {
                result += rim[number[i]];
            }
        }
        return result;

    } else throw out_of_range("Length out of range");
};

int main(){
    try {
        cout << romanToInt("III") << endl;
        cout << romanToInt("LVIII") << endl;
        cout << romanToInt("MCMXCIV") << endl;

    }
    catch(out_of_range oor) {
        cout << "Exception: " << oor.what() << endl;
    }

    return 0;
}
