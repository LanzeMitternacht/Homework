#include <iostream>

using namespace std;

template<typename T>
class Stack {
private:
    size_t m_capacity; // ёмкость
    size_t m_count; // количество элементов
    T* m_ptr; // указатель на данные

    void reallocate(size_t c) {
        if (!c) return;

        m_capacity = c;
        T* temp = new T[m_capacity];
        m_count = min<size_t>(m_count, m_capacity);
        copy(m_ptr, m_ptr + m_count, temp);

        delete[] m_ptr;
        m_ptr = temp;
    }
public:
    /*Конструктор*/
    Stack() :m_capacity(0), m_count(0), m_ptr(nullptr) {}
    /*Деконструтор*/
    ~Stack() {
        delete[] m_ptr;
    }
    /*Конструктор с задаными параметрами*/
    explicit Stack(size_t capacity) :m_capacity(capacity), m_count(0), m_ptr(new T[m_capacity]) {}
    /*Конструктор копирования*/
    Stack(const Stack& rhs) {
        m_capacity = rhs.m_capacity;
        m_ptr = new T[rhs.m_capacity];
        m_count = rhs.m_count;

        for (int i = 0; i < rhs.m_count; ++i) {
            m_ptr[i] = rhs.m_ptr[i];
        }
    }
    /*Оператор копирования*/
    Stack& operator=(const Stack& rhs) {
        if (this != &rhs) { // Если правая часть != левой части, ичане возращает левую часть
            delete[] m_ptr;
            m_capacity = rhs.m_capacity;
            m_ptr = new T[rhs.m_capacity];
            m_count = rhs.m_count;

            for (int i = 0; i < rhs.m_count; ++i) {
                m_ptr[i] = rhs.m_ptr[i];
            }
        }
        return *this;
    }
    /*Добавляет элемент на вершину стека*/
    void push(const T& value) {
        if (m_count >= m_capacity) { // Если количестко элементов >= ёмкости
            reallocate(max<size_t>(m_capacity, 1) * 2);
        }
        m_ptr[m_count] = value; // Добавление новых данных
        m_count++;
    }
    /*Возращает ссылку на верхний элемент стека*/
    T& top() {
        return m_ptr[m_count - 1];
    }
    /*Удаляет верхний элемент*/
    void pop() {
        if (empty()) {
            exit(1);
        }
        m_count--;
    }
    /*Возращает true в случае, если стек пуст*/
    bool empty() const {
        return m_count == 0;
    }
    /*Возращает количество элементов в стеке*/
    size_t size() const {
        return m_count;
    }
};
int main() {
    {
        Stack<int> s;
        cout << s.empty() << endl;
        s.push(10);
        s.push(50);
        s.push(100);
        cout << s.top() << " " << s.size() << endl;
        s.pop();
        cout << s.top() << endl;
    }

    {
        Stack<int> s(10);
        s.push(10);
        s.push(50);
        s.push(100);
        Stack<int> b = s;
        cout << b.empty() << " " << b.top() << endl;
    }

    {
        Stack<int> s(10);
        s.push(10);
        s.push(50);
        s.push(100);
        Stack<int> b;
        b.push(20);
        b.push(60);
        b.push(110);
        s = b;
        cout << s.top() << " " << s.size() << endl;
    }
    return 0;
}
