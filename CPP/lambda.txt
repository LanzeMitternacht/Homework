#include <iostream>
#include <vector>
#include <functional>

using namespace std;

void invoke(vector<function<void()>> functions){
    for (auto& elem : functions) {
        elem();
    }
}

int main(){
    auto hello = [](){
        cout << "Hi" << endl;
    };
    auto academian = []() {
        cout << "Academians" << endl;
    };
    auto exclamation = []() {
        cout << "!" << endl;
    };
   
   vector<function<void()>> lambda = {hello, academian, exclamation};
   invoke(lambda);
    return 0;
}


