#include <iostream>
#include <map>
#include <string>
#include <cassert>
using namespace std;


string IntToRoman(int number)
{
    string value = "";
    map<int, string> rim{
        { 1,    "I" },
        { 4,    "IV"},
        { 5,    "V" },
        { 9,    "IX"},
        { 10,   "X" },
        { 40,   "XL"},
        { 50,   "L" },
        { 90,   "XC"},
        { 100,  "C"},
        { 400,  "CD"},
        { 500,  "D"},
        { 900,  "CM"},
        { 1000, "M"},
    };

      while (number) {
            if (number >= 1000) {
                value += rim[1000];
                number -= 1000;
            }
            else if (number >= 1 && number < 4) {
                value += rim[1];
                --number;
            }
            else if (number == 4) {
                value += rim[4];
                number -= 4;
            }
            else if (number >= 5 && number < 9) {
                value += rim[5];
                number -= 5;
            }
            else if (number == 9) {
                value += rim[9];
                number -= 9;
            }
            else if (number >= 10 && number < 40) {
                value += rim[10];
                number -= 10;
            }
            else if (number >= 40 && number < 50) {
                value += rim[40];
                number -= 40;
            }
            else if (number >= 50 && number < 90) {
                value += rim[50];
                number -= 50;
            }
            else if (number >= 90 && number < 100) {
                value += rim[90];
                number -= 90;
            }
            else if (number >= 100 && number < 400) {
                value += rim[100];
                number -= 100;
            }
            else if (number >= 400 && number < 500) {
                value += rim[400];
                number -= 400;
            }
            else if (number >= 500 && number < 900) {
                value += rim[500];
                number -= 500;
            }
            else if (number >= 900 && number < 1000) {
                value += rim[900];
                number -= 900;
            }
      }
    return value;
}

int main()
{
    assert(IntToRoman(21) == "XXI");
    assert(IntToRoman(19) == "XIX");
    assert(IntToRoman(58) == "LVIII");
    assert(IntToRoman(1994) == "MCMXCIV");
    cout << "Complited" << endl;
    return 0;
}
