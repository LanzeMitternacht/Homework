#include <iostream>
#include <exception>

using namespace std;

template<typename T>
struct List {
    class Node {
        T m_data;
        Node* m_prev;
        Node* m_next;

    public:
        Node(T value) : m_data(value), m_prev(nullptr), m_next(nullptr) {}

        T& getData() { return m_data; }
        const T& getData() const { return m_data; }
        void setData(T value) { m_data = value; }

        Node* getPrev() const { return m_prev; }
        void setPrev(Node* node) { m_prev = node; }

        Node* getNext() const { return m_next; }
        void setNext(Node* node) { m_next = node; }
    };

    Node* m_head;
    Node* m_tail;

    List() : m_head(nullptr), m_tail(nullptr) {}

    List(const List& rhs) : m_head(nullptr), m_tail(nullptr) {
        Node* node = rhs.m_head;
        while (node != nullptr) {
            push_back(node->getData());
            node = node->getNext();
        }
    }

    List& operator=(const List& rhs) {
        if (this != &rhs) {
            clear();
            Node* node = rhs.m_head;
            while (node != nullptr) {
                push_back(node->getData());
                node = node->getNext();
            }
        }
        return *this;
    }

    ~List() {
        clear();
    }

    void push_front(T value) noexcept {
        Node* newNode = new Node(value);
        if (!m_head) {
            m_head = m_tail = newNode;
        }
        else {
            m_head->setPrev(newNode);
            newNode->setNext(m_head);
            m_head = newNode;
        }
    }

    void push_back(T value) noexcept {
        Node* newNode = new Node(value);
        if (!m_head) {
            m_head = m_tail = newNode;
        }
        else {
            m_tail->setNext(newNode);
            newNode->setPrev(m_tail);
            m_tail = newNode;
        }
    }

    void pop_front() noexcept {
        if (m_head) {
            Node* node = m_head;
            m_head = m_head->getNext();
            if (m_head) {
                m_head->setPrev(nullptr);
            }
            else {
                m_tail = nullptr;
            }
            delete node;
        }
    }

    void pop_back() {
        if (!m_head) {
            throw out_of_range("List is empty");
        }
        else {
            Node* node = m_tail;
            m_tail = m_tail->getPrev();
            if (m_tail) {
                m_tail->setNext(nullptr);
            }
            else {
                m_head = nullptr;
            }
            delete node;
        }
    }

    bool empty() const noexcept {
        return m_head == nullptr;
    }

    const T& at(int index) const {
        if (empty() || index >= size()) {
            throw out_of_range("Index out of range");
        }
        Node* node = m_head;
        for (int i = 0; i < index; ++i) {
            node = node->getNext();
        }
        return node->getData();
    }

    void clear() noexcept {
        while (m_head) {
            Node* node = m_head;
            m_head = m_head->getNext();
            delete node;
        }
        m_tail = nullptr;
    }

    int size() const noexcept {
        int size = 0;
        Node* node = m_head;
        while (node) {
            node = node->getNext();
            ++size;
        }
        return size;
    }

    void insert(int index, T value) {
        if (index < 0 || index > size()) {
            throw out_of_range("Index out of range");
        }
        if (index == 0) {
            push_front(value);
        }
        else if (index == size()) {
            push_back(value);
        }
        else {
            Node* current = m_head;
            for (int i = 0; i < index - 1; ++i) {
                current = current->getNext();
            }
            Node* newNode = new Node(value);
            newNode->setNext(current->getNext());
            newNode->setPrev(current);
            current->getNext()->setPrev(newNode);
            current->setNext(newNode);
        }
    }

    void remove(int index) {
        if (index < 0 || index >= size()) {
            throw out_of_range("Index out of range");
        }
        if (index == 0) {
            pop_front();
        }
        else if (index == size() - 1) {
            pop_back();
        }
        else {
            Node* current = m_head;
            for (int i = 0; i < index; ++i) {
                current = current->getNext();
            }
            Node* prevNode = current->getPrev();
            Node* nextNode = current->getNext();
            prevNode->setNext(nextNode);
            nextNode->setPrev(prevNode);
            delete current;
        }
    }
};

template<typename T>
void showList(const List<T>& l) {
    for (int i = 0; i < l.size(); i++) {
        cout << l.at(i) << " ";
    }
    cout << endl;
}

int questionNumber() {
    int number;
    cout << "Print your number: ";
    cin >> number;
    return number;
}

int questionIndex() {
    int index;
    cout << "Print your index: ";
    cin >> index;
    return index;
}

int quesiontContinue() {
    int result;
    cout << "Do you want to continue working or show the result?\n";
    cout << "0. Result\n" << "1. Continue\n";
    cin >> result;
    return result;
}

template<typename T>
void menu(List<T>& l) {
    int num;
    cout << "\tWhat you want?\n";
    cout << "1. Add number front\n";
    cout << "2. Add number back\n";
    cout << "3. Delete number front\n";
    cout << "4. Delete number back\n";
    cout << "5. Add number of index\n";
    cout << "6. Delete number of index\n";
    cout << "7. Print list\n";
    cout << "8. Exit\n";
    cin >> num;
    if (num < 0 || num > 8) {
        throw out_of_range("Index out of range");
    }
    switch (num)
    {
    case 1:
        l.push_front(questionNumber());
        break;
    case 2:
        l.push_back(questionNumber());
        break;
    case 3:
        l.pop_front();
        break;
    case 4:
        l.pop_back();
        break;
    case 5:
        l.insert(questionIndex(), questionNumber());
        break;
    case 6:
        l.remove(questionIndex());
        break;
    case 7:
        showList(l);
        break;
    default:
        cout << "Good bye\n";
        break;
    }
}

int main() {
    try {
        srand(static_cast<unsigned int>(time(NULL)));
        List<int> l;
        do {
            menu(l);
        } while (quesiontContinue());
        cout << "Size list: " << l.size() << endl;
        showList(l);
    }
    catch (out_of_range& oor) {
        cout << "Exception: " << oor.what() << endl;
    }
    return 0;
}
