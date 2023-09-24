#include <iostream>
#include <stdlib.h>


using namespace std;

class String {
protected:
    int m_size;
    wchar_t* m_string;
public:
    String() :m_size(0), m_string(nullptr) {
        m_string = (wchar_t*)malloc(m_size + 1);
        if (!m_string) exit(0);
    }
    explicit String(int size_n) : m_size(size_n), m_string(nullptr) {
        m_string = (wchar_t*)malloc(m_size + 1);
        if (!m_string) exit(0);
    }
    String(String& p) : m_size(p.m_size), m_string(p.m_string) {
        m_string = (wchar_t*)malloc(m_size + 1);
    }

    ~String() {
        
    }

    void setString(const wchar_t* char_ch);

    void print();

};


void String::setString(const wchar_t* char_ch) {
    size_t newLen = wcslen(char_ch) + 1;
    if (m_size != 0) {
        newLen = m_size;
    }
    else {
        m_size = newLen;
    }
    wchar_t* clone = nullptr;
    clone = (wchar_t*)malloc(newLen * sizeof(wchar_t));
    if (!clone) exit(0);
    for (int i = 0; i < newLen; i++) {
        clone[i] = char_ch[i];
    }
    free(m_string);
    m_string = clone;

}

void String::print() {
    wcout << "String: " << m_string << endl;
    wcout << "Size: " << m_size << endl;
}


int main() {
    String a;
    a.setString(L"Hello");
    a.print();

    String c;
    c = String(45);
    c.setString(L" World");
    c.print(); 

    return 0;
}
