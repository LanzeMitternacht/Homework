#include <iostream>

using namespace std;

class Player {
public:
    virtual void play() = 0;
    virtual void status() = 0;
};

class Attacker : public Player {
private:
    int m_HP;
    int m_damage;
    int m_def;

    void isDEF() {
        srand(time(NULL));
        int result = rand() % 2;
        if (result) {
            cout << "DEF";
        }
        else {
            cout << "UnDEF";
        }
    }
public:
   Attacker(int HP, int damage, int def) : m_HP(HP), m_damage(damage), m_def(def) {}
    void play() override {
        cout << "Attacker start the game\n";
    }

    void status() override {
        cout << "\tAttacker status:\n HP: " << m_HP << "\n Damage: " << m_damage << "\n Def: " << m_def << endl;
        cout << "Attacker in DEF: "; isDEF(); cout << endl;
    }
};

class Defender : public Player {
private:
    int m_HP;
    int m_damage;
    int m_def;

    void isDEF() {
        srand(time(NULL));
        int result = rand() % 2;
        if (result) {
            cout << "DEF";
        }
        else {
            cout << "UnDEF";
        }
    }
public:
    Defender(int HP, int damage, int def) :m_HP(HP), m_damage(damage), m_def(def) {}
    void play() override {
        cout << "Defender start the game\n";
    }

    void status() override {
        cout << "\tDefender status:\n HP: " << m_HP << "\n Damage: " << m_damage << "\n Def: " << m_def << endl;
        cout << "Defender in DEF: "; isDEF(); cout << endl;
    }
};


class PlayerFactory {
public:
    virtual Player* createAttacker(int HP, int damage, int def) = 0;
    virtual Player* createDefender(int HP, int damage, int def) = 0;
};


class ConcretePlayerFactory : public PlayerFactory {
public:
    Player* createAttacker(int HP, int damage, int def) override {
        return new Attacker(HP, damage, def);
    }

    Player* createDefender(int HP, int damage, int def) override {
        return new Defender(HP, damage, def);
    }
};

int main() {

    PlayerFactory* factory = new ConcretePlayerFactory();
    Player* attacker = factory->createAttacker(100,5,6);
    Player* defender = factory->createDefender(100,4,7);

    attacker->play();
    defender->play();
    attacker->status();
    defender->status();

    delete attacker;
    delete defender;
    delete factory;

    return 0;
}