#include <iostream>
#include <array>
#include <algorithm>
using namespace std;

int main() {
    srand(time(NULL));
    auto print = [](auto arr) {
        for (auto i : arr) {
            cout << i << " ";
        }
        cout << endl;
    };

    array<int, 10> arr;
    for (auto& i : arr) i = rand() % 10;
    cout << "Random array: ";
    print(arr);

    sort(arr.begin(), arr.end());
    cout << "Sort array: ";
    print(arr);

    int uniq = 0;
    for (int i = 0; i < arr.size(); i++) {
        if (arr[i] < 0) {
            continue;
        }
        for (int j = 0; j < arr.size(); j++) {
            if (i == j)
                continue;
            if (arr[i] == arr[j]) {
                uniq++;
                arr[j] = -1;
            }
        }
        if (uniq > 0) {
            cout << arr[i] << " finded " << ++uniq << " times" << endl;
            uniq = 0;
        }
    }
	return 0;
}
