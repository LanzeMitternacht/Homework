#include <iostream>
#include <stdexcept>
#include <algorithm>

using namespace std;

template <typename T>
class Vec {
private:
    T* m_ptr;
    size_t m_count;
    size_t m_capacity;

    void reallocate() noexcept {
        m_capacity = max<size_t>(1, m_capacity * 2);
        T* tmp = new T[m_capacity];
        copy(m_ptr, m_ptr + m_count, tmp);
        delete[] m_ptr;
        m_ptr = tmp;
    }

public:
    Vec() : m_ptr(nullptr), m_count(0), m_capacity(0) {}
    Vec(size_t initial_capacity) : m_ptr(new T[initial_capacity]), m_count(0), m_capacity(initial_capacity) {}
    ~Vec() { delete[] m_ptr; }

    Vec(const Vec& rhs) : m_ptr(rhs.m_count ? new T[rhs.m_count] : nullptr), m_count(rhs.m_count), m_capacity(rhs.m_count) {
        copy(rhs.m_ptr, rhs.m_ptr + rhs.m_count, m_ptr);
    }

    Vec& operator=(const Vec& rhs) {
        if (this != &rhs) {
            delete[] m_ptr;
            m_ptr = rhs.m_count ? new T[rhs.m_count] : nullptr;
            m_count = rhs.m_count;
            m_capacity = rhs.m_capacity;
            if (m_ptr) {
                copy(rhs.m_ptr, rhs.m_ptr + rhs.m_count, m_ptr);
            }
        }
        return *this;
    }

    Vec(Vec&& rhs) noexcept : Vec() {
        swap(m_ptr, rhs.m_ptr);
        swap(m_count, rhs.m_count);
        swap(m_capacity, rhs.m_capacity);
    }

    Vec& operator=(Vec&& rhs) noexcept {
        if (this != &rhs) {
            delete[] m_ptr;
            m_ptr = rhs.m_ptr;
            m_count = rhs.m_count;
            m_capacity = rhs.m_capacity;

            rhs.m_ptr = nullptr;
            rhs.m_count = 0;
            rhs.m_capacity = 0;
        }
        return *this;
    }

    T& operator[](int index) {
        if (index < 0 || static_cast<size_t>(index) >= m_count) {
            throw out_of_range("Index out of range");
        }
        return m_ptr[index];
    }

    const T& operator[](int index) const {
        if (index < 0 || static_cast<size_t>(index) >= m_count) {
            throw out_of_range("Index out of range");
        }
        return m_ptr[index];
    }

    Vec operator+(const T& value) const {
        Vec result(m_count);
        for (size_t i = 0; i < m_count; i++) {
            result.m_ptr[i] = m_ptr[i] + value;
        }
        result.m_count = m_count;
        return result;
    }

    Vec& operator+=(const T& value) {
        for (size_t i = 0; i < m_count; i++) {
            m_ptr[i] += value;
        }
        return *this;
    }

    Vec operator-(const T& value) const {
        Vec result(m_count);
        for (size_t i = 0; i < m_count; i++) {
            result.m_ptr[i] = m_ptr[i] - value;
        }
        result.m_count = m_count;
        return result;
    }

    Vec& operator-=(const T& value) {
        for (size_t i = 0; i < m_count; i++) {
            m_ptr[i] -= value;
        }
        return *this;
    }

    size_t size() const noexcept {
        return m_count;
    }

    size_t capacity() const noexcept {
        return m_capacity;
    }

    bool empty() const noexcept {
        return m_count == 0;
    }

    void clear() noexcept {
        m_count = 0;
    }

    void insert(size_t pos, const T& item) {
        if (pos > m_count) {
            throw out_of_range("Index out of range");
        }
        if (m_count == m_capacity) {
            reallocate();
        }
        for (size_t i = m_count; i > pos; --i) {
            m_ptr[i] = m_ptr[i - 1];
        }
        m_ptr[pos] = item;
        m_count++;
    }

    void push_back(const T* items, size_t size) {
        for (size_t i = 0; i < size; i++) {
            insert(m_count, items[i]);
        }
    }

    void push_back(const T& item) {
        insert(m_count, item);
    }

    void push_front(const T& item) {
        insert(0, item);
    }

    void pop_back() {
        if (m_count == 0) {
            throw runtime_error("Attempt to pop from an empty array");
        }
        m_count--;
    }

    void pop_front() {
        if (m_count == 0) {
            throw runtime_error("Attempt to pop from an empty array");
        }
        for (size_t i = 0; i < m_count - 1; i++) {
            m_ptr[i] = m_ptr[i + 1];
        }
        m_count--;
    }

    void remove(int index) {
        if (index < 0 || static_cast<size_t>(index) >= m_count) {
            throw out_of_range("Index out of range");
        }
        for (size_t i = index; i < m_count - 1; i++) {
            m_ptr[i] = m_ptr[i + 1];
        }
        m_count--;
    }

    void reverse() {
        size_t left = 0;
        size_t right = m_count - 1;
        while (left < right) {
            swap(m_ptr[left], m_ptr[right]);
            ++left;
            --right;
        }
    }
};

int main() {
    Vec<int> v;
    v.push_back(5);
    v.push_back(8);

    for (size_t i = 0; i < v.size(); i++) {
        cout << v[i] << " ";
    }
    cout << endl;

    v.remove(0);
    for (size_t i = 0; i < v.size(); i++) {
        cout << v[i] << " ";
    }
    cout << endl;

    return 0;
}
