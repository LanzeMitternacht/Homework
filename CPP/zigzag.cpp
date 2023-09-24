#include <iostream>
#include <string>
#include <vector>

using namespace std;

string convert(string s, int numRows) {
    if (numRows <= 1) {
        return s;
    }
    string temp;
    vector<string> temp1(numRows);
    int ssize = s.size();
    int count = 0;
    while (count < ssize) {
        for (int i = 0; i < numRows && count < ssize; i++) {
            temp1[i] += s[count++];
        }
        for (int i = numRows - 2; i > 0 && count < ssize; i--) {
            temp1[i] += s[count++];
        }
    }
    for (auto& iter : temp1) {
        temp += iter;
    }
    return temp;
}


int main(){
    string s = convert("PAYPALISHIRING", 3);
    cout << s << endl;
    return 0;
}
