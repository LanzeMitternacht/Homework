#include <iostream>
#include <string>
#include <cassert>

using namespace std;

int alphabetToInt(string str) {
    int result = 0;
    for (char chr : str) {
        int temp = chr - 'A' + 1;
        result = result * 26 + temp;
    }
    return result;
}


int main(){
    
    assert(alphabetToInt("A") == 1);
    assert(alphabetToInt("B") == 2);
    assert(alphabetToInt("Z") == 26);
    assert(alphabetToInt("AA") == 27);
    assert(alphabetToInt("") == 0);
    return 0;
}
