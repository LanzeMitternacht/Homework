#include <iostream>
#include <string>

using namespace std;

string str;
string intToString(int i) {
    char c = '\0';
    if (i >= 27) {
        i -= 26;
        c = 'A' - 1 + i;
        str += c;
    }
    else {
        c = 'A' - 1 + i;
        i -= 26;
        str += c;
    }
    if(i >= 1)
        intToString(i);

    return str;
}




int main(){
    int i = 0;
    cout << "Write your number: \n";
    cin >> i;
    cout << intToString(i) << endl;
    
    return 0;
}
