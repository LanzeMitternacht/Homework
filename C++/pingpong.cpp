#include <iostream>
#include <mutex>
#include <chrono>
#include <condition_variable>
#include <thread>

using namespace std;

mutex mtxping, mtxpong;
condition_variable cvping, cvpong;
bool flagping = false, flagpong = false;

void Ping() {
    while (true) {
        unique_lock<mutex> lck(mtxping);
        cvping.wait(lck, [] {return flagpong; });
        cout << "\t\tPing ";
        this_thread::sleep_for(chrono::milliseconds(500));
        flagpong = false;
        flagping = true;
        cvpong.notify_one();
        
    }
}
void Pong() {
    while (true) {
        unique_lock<mutex> lck(mtxpong);
        cvpong.wait(lck, [] {return flagping; });
        cout << "Pong" << endl;
        this_thread::sleep_for(chrono::milliseconds(500));
        flagping = false;
        flagpong = true;
        cvping.notify_one();
    }
}

int main(){
    thread t1(Ping);
    thread t2(Pong);
    
    if (cin.get()) {
        flagpong = true;
        cvping.notify_one();
    }

    t1.join();
    t2.join();

    return 0;
}





