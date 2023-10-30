#include <iostream>
#include <string>
#include <sstream>

using namespace std;

template<typename T>
T _sum_(T fnum, T snum) {
    return fnum + snum;
}


template<typename T, typename U, typename = enable_if_t<is_arithmetic_v<T>>>
T _sum_(T fnum, U snum) {
    return fnum + snum;
}

template<> string _sum_<string>(string s, string s1) = delete;


template<typename T>
void _swap_(T& fnum, T& snum) {
    T temp = fnum;
    fnum = snum;
    snum = temp;
}



int main(){
   cout << _sum_(2, 3) << endl;
   cout << _sum_(2, 3.3) << endl;
   cout << _sum_('A', 'B') << endl;
   cout << _sum_('A', 1) << endl;

   int i = 1, j = 2;
   _swap_(i, j);
   cout << i << " " << j << endl;

   char a = 'A', b = 'B';
   _swap_(a, b);
   cout << a << " " << b << endl;

   string s1 = "Hello", s2 = "World";
   _swap_(s1, s2);
   cout << s1 << " " << s2 << endl;
    return 0;
}
