#include <iostream>
#include <vector>
#include <mutex>
#include <future>
using namespace std;

mutex mtx;
void multmtx(vector<vector<int>>& fvec, vector<vector<int>>& svec) {
    lock_guard<mutex> lck(mtx);
    for (int i = 0; i < fvec.size(); i++) {
        for (int j = 0; j < svec.size(); j++) {
            fvec[i][j] = fvec[i][j] * svec[i][j];            
        }
    }
}
void print(vector<vector<int>>& fvec) {
    for (int i = 0; i < fvec.size(); i++) {
        for (int j = 0; j < fvec.size(); j++) {
            cout << fvec[i][j] << " ";
        }
        cout << endl;
    }
}

int main(){
    vector<vector<int>> first{ { 1,3 },{ 4,1} };
    vector<vector<int>> second{ { 2,2 },{ 1,1} };
    vector<vector<int>> third{ { 3,1 },{ 4,1 } };
    vector<vector<int>> fourth{ { 5,2 },{ 2,3 } };
    auto a1 = async(launch::async, multmtx, ref(first), ref(second));
    auto a2 = async(launch::async, multmtx, ref(third), ref(fourth));
    auto a3 = async(launch::async, multmtx, ref(first), ref(third));
    a3.wait();
    print(first);
    return 0;
}


