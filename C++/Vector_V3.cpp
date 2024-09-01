#include <iostream>
#include <stdexcept>
#include <algorithm>

template <typename T>
class Vec {
private:
    T* m_ptr;
    size_t m_count;
    size_t m_capacity;

    void reallocate() noexcept {
        m_capacity = std::max<size_t>(1, m_capacity * 2);
        T* tmp = new T[m_capacity];
        std::copy(m_ptr, m_ptr + m_count, tmp);
        delete[] m_ptr;
        m_ptr = tmp;
    }

public:
    Vec() : m_ptr(nullptr), m_count(0), m_capacity(0) {}
    Vec(size_t initial_capacity) : m_ptr(new T[initial_capacity]), m_count(0), m_capacity(initial_capacity) {}
    ~Vec() { delete[] m_ptr; }

    Vec(const Vec& rhs) : m_ptr(rhs.m_count ? new T[rhs.m_count] : nullptr), m_count(rhs.m_count), m_capacity(rhs.m_count) {
        std::copy(rhs.m_ptr, rhs.m_ptr + rhs.m_count, m_ptr);
    }

    Vec& operator=(const Vec& rhs) {
        if (this != &rhs) {
            delete[] m_ptr;
            m_ptr = rhs.m_count ? new T[rhs.m_count] : nullptr;
            m_count = rhs.m_count;
            m_capacity = rhs.m_capacity;
            if (m_ptr) {
                std::copy(rhs.m_ptr, rhs.m_ptr + rhs.m_count, m_ptr);
            }
        }
        return *this;
    }

    Vec(Vec&& rhs) noexcept : Vec() {
        std::swap(m_ptr, rhs.m_ptr);
        std::swap(m_count, rhs.m_count);
        std::swap(m_capacity, rhs.m_capacity);
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
            throw std::out_of_range("Index out of range");
        }
        return m_ptr[index];
    }

    const T& operator[](int index) const {
        if (index < 0 || static_cast<size_t>(index) >= m_count) {
            throw std::out_of_range("Index out of range");
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
            throw std::out_of_range("Index out of range");
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
            throw std::runtime_error("Attempt to pop from an empty array");
        }
        m_count--;
    }

    void pop_front() {
        if (m_count == 0) {
            throw std::runtime_error("Attempt to pop from an empty array");
        }
        for (size_t i = 0; i < m_count - 1; i++) {
            m_ptr[i] = std::move(m_ptr[i + 1]);
        }
        m_count--;
    }

    void remove(int index) {
        if (index < 0 || static_cast<size_t>(index) >= m_count) {
            throw std::out_of_range("Index out of range");
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
            std::swap(m_ptr[left], m_ptr[right]);
            ++left;
            --right;
        }
    }

    void print() const noexcept {
        for (size_t i = 0; i < m_count; i++) {
            std::cout << m_ptr[i] << " ";
        }
        std::cout << std::endl;
    }

    void fill(size_t begin, size_t end, const T& data) {
        if (begin > end || end > m_capacity)
            throw std::out_of_range("Invalid range for fill operation");
        for (size_t i = begin; i < end; i++) {
            m_ptr[i] = data;
        }
    }
};

int main() {
    Vec<int> vec(5);

    vec.push_back(1);
    vec.push_back(2);
    vec.push_back(3);
    vec.push_front(0);

    std::cout << "After adding elements: ";
    vec.print();

    std::cout << "Element at index 2: " << vec[2] << std::endl;

    vec += 10;
    std::cout << "After adding 10 to all elements: ";
    vec.print();

    vec -= 5;
    std::cout << "After subtracting 5 from all elements: ";
    vec.print();

    vec.insert(2, 99);
    std::cout << "After inserting 99 at index 2: ";
    vec.print();

    vec.remove(2);
    std::cout << "After removing element at index 2: ";
    vec.print();

    vec.reverse();
    std::cout << "After reversing: ";
    vec.print();

    vec.fill(0, 3, 7);
    std::cout << "After filling first three elements with 7: ";
    vec.print();

    vec.pop_back();
    std::cout << "After removing last element: ";
    vec.print();

    vec.pop_front();
    std::cout << "After removing first element: ";
    vec.print();

    std::cout << "Is vector empty? " << (vec.empty() ? "Yes" : "No") << std::endl;

    vec.clear();
    std::cout << "After clearing: ";
    vec.print();
    std::cout << "Is vector empty? " << (vec.empty() ? "Yes" : "No") << std::endl;

    return 0;
}
