#include <iostream>
#include <string>


using namespace std;
#if 0
class Sneakers {
public:
    void setSize(int size_i);
    int setSize() const;

    void setWeight(int weight_gr);
    int setWeight() const;

    void setPrice(double price_d);
    double setPrice() const;

    void setColor(string color_s);
    string setColor() const;

    void setType(string type_s);
    string setType() const;

    void setLacing(string lacing_s);
    string setLacing() const;

    void isMoiSepa(bool isMoiSepa_b);
    bool isMoiSepa() const;

    void setMaterialUp(string materialUp_s);
    string setMaterialUp() const;

    void setMaterialInside(string materialInside_s);
    string setMaterialInside() const;

    void setMaterialSole(string materialSole_s);
    string setMaterialSole() const;

    void setModelGender(char modelGender_c);
    char setModelGender() const;

    void setMark(string mark_s);
    string setMark() const;

    void isReflective(bool reflective_b);
    bool isReflective() const;

    void isDiscount(bool discount_b);
    bool isDiscount() const;

    void setDiscount(int discount_i, double price_d);
    int setDiscount() const;

    void showIsFunc(bool isFunc);
    
protected:
    int m_size_i;
    int m_weight_gr;
    int m_discount_i;
    double m_price_d;
    string m_color_s;
    string m_type_s;
    string m_lacing_s;
    string m_materialUp_s;
    string m_materialInside_s;
    string m_materialSole_s;
    string m_mark_s;
    char m_modelGender_c = '\0';
    bool m_isMoiSepa_b = false;
    bool m_reflective_b = false;
    bool m_isdiscount_b = false;
};

void Sneakers::setSize(int size_i) {
    m_size_i = size_i;
}
int Sneakers::setSize() const{
    return m_size_i;
}

void Sneakers::setWeight(int weight_gr) {
    m_weight_gr = weight_gr;
}
int Sneakers::setWeight() const {
    return m_weight_gr;
}

void Sneakers::setPrice(double price_d) {
    m_price_d = price_d;
}
double Sneakers::setPrice() const {
    return m_price_d;
}

void Sneakers::setColor(string color_s) {
    m_color_s = color_s;
}
string Sneakers::setColor() const {
    return m_color_s;
}

void Sneakers::setType(string type_s) {
    m_type_s = type_s;
}
string Sneakers::setType() const {
    return m_type_s;
}

void Sneakers::setLacing(string lacing_s) {
    m_lacing_s = lacing_s;
}
string Sneakers::setLacing() const {
    return m_lacing_s;
}

void Sneakers::isMoiSepa(bool isMoiSepa_b) {
    m_isMoiSepa_b = isMoiSepa_b;
}
bool Sneakers::isMoiSepa() const {
    return m_isMoiSepa_b;
}

void Sneakers::setMaterialUp(string materialUp_s) {
    m_materialUp_s = materialUp_s;
}
string Sneakers::setMaterialUp() const {
    return m_materialUp_s;
}

void Sneakers::setMaterialSole(string materialSole_s) {
    m_materialSole_s = materialSole_s;
}
string Sneakers::setMaterialSole() const {
    return m_materialSole_s;
}

void Sneakers::setMaterialInside(string materialInside_s) {
    m_materialInside_s = materialInside_s;
}
string Sneakers::setMaterialInside() const {
    return m_materialInside_s;
}

void Sneakers::setModelGender(char modelGender_c) {
    m_modelGender_c = modelGender_c;
}
char Sneakers::setModelGender() const {
    return m_modelGender_c;
}

void Sneakers::setMark(string mark_s) {
    m_mark_s = mark_s;
}
string Sneakers::setMark() const {
    return m_mark_s;
}

void Sneakers::isReflective(bool reflective_b) {
    m_reflective_b = reflective_b;
}
bool Sneakers::isReflective() const {
    return m_reflective_b;
}

void Sneakers::isDiscount(bool discount_b) {
    m_isdiscount_b = discount_b;
}
bool Sneakers::isDiscount() const {
    return m_isdiscount_b;
}

void Sneakers::setDiscount(int discount_i, double price_d) {
    m_price_d = (price_d * discount_i) / 100;
    m_discount_i = discount_i;
}
int Sneakers::setDiscount() const {
    return m_discount_i;
}

void Sneakers::showIsFunc(bool isFunc) {
    (isFunc) ? cout << "Yes\n" : cout << "No\n";
}


int main(){
    setlocale(LC_ALL, "rus");
    Sneakers sneaker;
    sneaker.setSize(42);
    sneaker.setWeight(1000);
    sneaker.setPrice(4500);
    sneaker.setModelGender('M');
    sneaker.setColor("Black");
    sneaker.setMark("Heal");
    sneaker.isReflective(true);
    sneaker.setType("Sport");
    sneaker.setMaterialUp("Skin");
    sneaker.setMaterialSole("Foam");
    sneaker.setMaterialInside("Fur");
    sneaker.isMoiSepa(false);
    sneaker.isDiscount(true);
    sneaker.setDiscount(15, 4500);

    cout << "\t\t\tКроссовки\n\n";
    cout << "\tПроизводитель:\t\t" << sneaker.setMark() << endl;
    cout << "\tПол:\t\t\t" << sneaker.setModelGender() << endl;
    cout << "\tРазмер обуви:\t\t" << sneaker.setSize() << endl;
    cout << "\tВес обуви:\t\t" << sneaker.setWeight() << " гр" << endl;
    cout << "\tЦена обуви:\t\t" << sneaker.setPrice() << " рублей" << endl;
    cout << "\tЦвет обуви:\t\t" << sneaker.setColor() << endl;
    cout << "\tСветоотражатель:\t"; sneaker.showIsFunc(sneaker.isReflective()); 
    cout << "\tТип обуви:\t\t" << sneaker.setType() << endl;
    cout << "\tВнешний материал:\t" << sneaker.setMaterialUp() << endl;
    cout << "\tПодошва:\t\t" << sneaker.setMaterialSole() << endl;
    cout << "\tВнутрений материал:\t" << sneaker.setMaterialInside() << endl;
    cout << "\tВлагооткл поверхость:\t"; sneaker.showIsFunc(sneaker.isMoiSepa());
    cout << "\tСкидка:\t\t\t" << sneaker.setDiscount() << " %" << endl;
    return 0;
}

#endif

#if 0
class Tshirt {
public:
    void setPrice(int price_n);
    int setPrice() const;

    void setSize(int size_n);
    int setSize() const;

    void setHeight(int height_сm);
    int setHeight() const;

    void setDiscount(int discount_n, int price_n);
    int setDiscount() const;

    void setColor(string color_s);
    string setColor() const;

    void setName(string name_s);
    string setName() const;

    void setStructure(string structure_s);
    string setStructure() const;

    void setPrint(string print_s);
    string setPrint() const;

    void setMade(string made_s);
    string setMade() const;

    void setOutlines(string outlines_s);
    string setOutlines() const;

    void setNeck(string neck_s);
    string setNeck() const;

    void setGender(char gender_c);
    char setGender() const;

    void isDiscount(bool isDiscount_b);
    bool isDiscount() const;

    void showIsFunc(bool isFunc);

protected:
    int m_price;
    int m_size;
    int m_height_сm;
    int m_discount;
    string m_color;
    string m_name;
    string m_structure;
    string m_print;
    string m_made;
    string m_outlines;
    string m_neck;
    char m_gender;
    bool m_isdiscount;
};

    void Tshirt::setPrice(int price_n) {
        m_price = price_n;
    }
    int Tshirt::setPrice() const {
        return m_price;
    }

    void Tshirt::setSize(int size_n){
        m_size = size_n;
    }
    int Tshirt::setSize() const{
        return m_size;
    }

    void Tshirt::setHeight(int height_сm){
        m_height_сm = height_сm;
    }
    int Tshirt::setHeight() const{
        return m_height_сm;
    }

    void Tshirt::setDiscount(int discount_n, int price_n){
        m_price = (price_n * discount_n) / 100;
        m_discount = discount_n;
    }
    int Tshirt::setDiscount() const{
        return m_discount;
    }

    void Tshirt::setColor(string color_s){
        m_color = color_s;
    }
    string Tshirt::setColor() const{
        return m_color;
    }

    void Tshirt::setName(string name_s){
        m_name = name_s;
    }
    string Tshirt::setName() const{
        return m_name;
    }

    void Tshirt::setStructure(string structure_s){
        m_structure = structure_s;
    }
    string Tshirt::setStructure() const{
        return m_structure;
    }

    void Tshirt::setPrint(string print_s){
        m_print = print_s;
    }
    string Tshirt::setPrint() const{
        return m_print;
    }

    void Tshirt::setMade(string made_s){
        m_made = made_s;
    }
    string Tshirt::setMade() const{
        return m_made;
    }

    void Tshirt::setOutlines(string outlines_s){
        m_outlines = outlines_s;
    }
    string Tshirt::setOutlines() const{
        return m_outlines;
    }

    void Tshirt::setNeck(string neck_s){
        m_neck = neck_s;
    }
    string Tshirt::setNeck() const{
        return m_neck;
    }

    void Tshirt::setGender(char gender_c){
        m_gender = gender_c;
    }
    char Tshirt::setGender() const{
        return m_gender;
    }

    void Tshirt::isDiscount(bool isDiscount_b){
        m_discount = isDiscount_b;
    }
    bool Tshirt::isDiscount() const{
        return m_discount;
    }

    void Tshirt::showIsFunc(bool isFunc){
        (isFunc) ? cout << "Yes\n" : cout << "No\n";
    }

int main() {
    Tshirt tishe;
    setlocale(LC_ALL, "rus");
    tishe.setName("Футболка kindergarten");
    tishe.setGender('W');
    tishe.setColor("Белый");
    tishe.setHeight(177);
    tishe.setPrice(1750);
    tishe.isDiscount(true);
    tishe.setDiscount(20, tishe.setPrice());
    tishe.setSize(48);
    tishe.setNeck("Круглый");
    tishe.setOutlines("Прямой");
    tishe.setPrint("Надпись, печать, сюжетный");
    tishe.setStructure("Хлопок");
    tishe.setMade("Germany");


    cout << "\t\t\tФутблока\n\n";
    cout << "\tНазвание товара:\t" << tishe.setName() << endl;
    cout << "\tПол:\t\t\t" << tishe.setGender() << endl;
    cout << "\tЦвет товара:\t\t" << tishe.setColor() << endl;
    cout << "\tЦена товара:\t\t" << tishe.setPrice() << " rub" << endl;
    cout << "\tСкидка:\t\t\t" << tishe.setDiscount() << " %" << endl;
    cout << "\tРост:\t\t\t" << tishe.setHeight() << " cm" << endl;
    cout << "\tРазмер:\t\t\t" << tishe.setSize() << endl;
    cout << "\tСилуэт:\t\t\t" << tishe.setOutlines() << endl;
    cout << "\tВирез головины:\t\t" << tishe.setNeck() << endl;
    cout << "\tПринт:\t\t\t" << tishe.setPrint() << endl;
    cout << "\tСостав:\t\t\t" << tishe.setStructure() << endl;
    cout << "\tСтрана производитель:\t" << tishe.setMade() << endl;

    return 0;
}
#endif

#if 0

class Scales {
protected:
    int m_price;
    int m_maxLoad_kg;
    int m_measurementAccuracy_g;
    int m_guarantee_mth;
    double m_width_cm;
    double m_height_cm;
    double m_depth_cm;
    double m_weight_kg;
    string m_type;
    string m_view;
    string m_model;
    string m_color;
    string m_material;
    string m_unitsOfMeasurement;
    string m_additionally;
    string m_made;
    bool m_memory;
    bool m_autoOffOn;
    bool m_voiceHelp;
    bool m_chargeIndicator;
    bool m_illumination;
public:

    void setPrice(int price_n);
    int setPrice() const;

    void setMaxLoad(int maxLoad_kg);
    int setMaxLoad() const;

    void setMeasurementAccuracy(int measurementAccuracy_g);
    int setMeasurementAccuracy() const;

    void setGuarantee(int guarantee_mth);
    int setGuarantee() const;

    void setWidth(double width_cm);
    double setWidth() const;

    void setHeight(double height_cm);
    double setHeight() const;

    void setDepth(double depth_cm);
    double setDepth() const;

    void setWeight(double weight_kg);
    double setWeight() const;

    void setType(string type_s);
    string setType() const;

    void setView(string view_s);
    string setView() const;

    void setModel(string model_s);
    string setModel() const;

    void setColor(string color_s);
    string setColor() const;

    void setMaterial(string material_s);
    string setMaterial() const;

    void setUnitsOfMeasurement(string unitsOfMeasurement_s);
    string setUnitsOfMeasurement() const;

    void setAdditionally(string additionally_s);
    string setAdditionally() const;

    void setMade(string made_s);
    string setMade() const;

    void isMemory(bool memory_b);
    bool isMemory() const;

    void isAutoOffOn(bool autoOffOn_b);
    bool isAutoOffOn() const;

    void isVoiceHelp(bool voiceHelp_b);
    bool isVoiceHelp() const;

    void isChargeIndicator(bool chargeIndicator_b);
    bool isChargeIndicator() const;

    void isIllumination(bool illumination_b);
    bool isIllumination() const;

    void showIsFunc(bool isFunc);

    void print() {
        cout << "\n\t\t\t\tВесы\n\n";
        cout << "\tМодель:\t\t\t\t" << m_model << endl;
        cout << "\tТип:\t\t\t\t" << m_type << endl;
        cout << "\tВид:\t\t\t\t" << m_view << endl;
        cout << "\tЦвет:\t\t\t\t" << m_color << endl;
        cout << "\tМатериал:\t\t\t" << m_material << endl;
        cout << "\tЕдиницы измерения:\t\t" << m_unitsOfMeasurement << endl;
        cout << "\tДополнительно:\t\t\t" << m_additionally << endl;
        cout << "\tПроизводитель:\t\t\t" << m_made << endl;
        cout << "\tЦена:\t\t\t\t" << m_price << " руб" << endl;
        cout << "\tМаксимальная нагрузка:\t\t" << m_maxLoad_kg << " кг" << endl;
        cout << "\tТочность измерения:\t\t" << m_measurementAccuracy_g << " г" << endl;
        cout << "\tГарантия производителя:\t\t" << m_guarantee_mth << " мес" << endl;
        cout << "\tШирина:\t\t\t\t" << m_width_cm << " см" << endl;
        cout << "\tВысота:\t\t\t\t" << m_height_cm << " см" << endl;
        cout << "\tГлубина:\t\t\t" << m_depth_cm << " см" << endl;
        cout << "\tВес:\t\t\t\t" << m_weight_kg << " кг" << endl;
        cout << "\tПамять:\t\t\t\t"; showIsFunc(m_memory);
        cout << "\tАвтоматическое вкл/выкл:\t"; showIsFunc(m_autoOffOn);
        cout << "\tГолосовой помощник:\t\t"; showIsFunc(m_voiceHelp);
        cout << "\tИндикатор заряда:\t\t"; showIsFunc(m_chargeIndicator);
        cout << "\tОсвещение дисплея:\t\t"; showIsFunc(m_illumination);
    }
};

    void Scales::setPrice(int price_n){
        m_price = price_n;
    }
    int Scales::setPrice() const{
        return m_price;
    }

    void Scales::setMaxLoad(int maxLoad_kg){
        m_maxLoad_kg = maxLoad_kg;
    }
    int Scales::setMaxLoad() const{
        return m_maxLoad_kg;
    }

    void Scales::setMeasurementAccuracy(int measurementAccuracy_g){
        m_measurementAccuracy_g = measurementAccuracy_g;
    }
    int Scales::setMeasurementAccuracy() const{
        return m_measurementAccuracy_g;
    }

    void Scales::setGuarantee(int guarantee_mth){
        m_guarantee_mth = guarantee_mth;
    }
    int Scales::setGuarantee() const{
        return m_guarantee_mth;
    }

    void Scales::setWidth(double width_cm){
        m_width_cm = width_cm;
    }
    double Scales::setWidth() const{
        return m_width_cm;
    }

    void Scales::setHeight(double height_cm){
        m_height_cm = height_cm;
    }
    double Scales::setHeight() const{
        return m_height_cm;
    }

    void Scales::setDepth(double depth_cm){
        m_depth_cm = depth_cm;
    }
    double Scales::setDepth() const{
        return m_depth_cm;
    }

    void Scales::setWeight(double weight_kg){
        m_weight_kg = weight_kg;
    }
    double Scales::setWeight() const{
        return m_weight_kg;
    }

    void Scales::setType(string type_s){
        m_type = type_s;
    }
    string Scales::setType() const{
        return m_type;
    }

    void Scales::setView(string view_s){
        m_view = view_s;
    }
    string Scales::setView() const{
        return m_view;
    }

    void Scales::setModel(string model_s){
        m_model = model_s;
    }
    string Scales::setModel() const{
        return m_model;
    }

    void Scales::setColor(string color_s){
        m_color = color_s;
    }
    string Scales::setColor() const{
        return m_color;
    }

    void Scales::setMaterial(string material_s){
        m_material = material_s;
    }
    string Scales::setMaterial() const{
        return m_material;
    }

    void Scales::setUnitsOfMeasurement(string unitsOfMeasurement_s){
        m_unitsOfMeasurement = unitsOfMeasurement_s;
    }
    string Scales::setUnitsOfMeasurement() const{
        return m_unitsOfMeasurement;
    }

    void Scales::setAdditionally(string additionally_s){
        m_additionally = additionally_s;
    }
    string Scales::setAdditionally() const{
        return m_additionally;
    }

    void Scales::setMade(string made_s){
        m_made = made_s;
    }
    string Scales::setMade() const{
        return m_made;
    }

    void Scales::isMemory(bool memory_b){
        m_memory = memory_b;
    }
    bool Scales::isMemory() const{
        return m_memory;
    }

    void Scales::isAutoOffOn(bool autoOffOn_b){
        m_autoOffOn = autoOffOn_b;
    }
    bool Scales::isAutoOffOn() const{
        return m_autoOffOn;
    }

    void Scales::isVoiceHelp(bool voiceHelp_b){
        m_voiceHelp = voiceHelp_b;
    }
    bool Scales::isVoiceHelp() const{
        return m_voiceHelp;
    }

    void Scales::isChargeIndicator(bool chargeIndicator_b){
        m_chargeIndicator = chargeIndicator_b;
    }
    bool Scales::isChargeIndicator() const{
        return m_chargeIndicator;
    }

    void Scales::isIllumination(bool illumination_b){
        m_illumination = illumination_b;
    }
    bool Scales::isIllumination() const{
        return m_illumination;
    }

    void Scales::showIsFunc(bool isFunc){
        (isFunc) ? cout << "Yes\n" : cout << "No\n";
    }

int main() {
    setlocale(LC_ALL, "rus");
    Scales scales;

    scales.setModel("DEXP SCGM - 26P");
    scales.setType("Весы");
    scales.setView("Электронные");
    scales.setColor("Зеленый");
    scales.setMaterial("Стекло");
    scales.setUnitsOfMeasurement("Килограммы, стоуны, фунты");
    scales.setAdditionally("Прорезиненные ножки");
    scales.setMade("Китай");
    scales.setPrice(450);
    scales.setMaxLoad(180);
    scales.setMeasurementAccuracy(100);
    scales.setGuarantee(12);
    scales.setWidth(26);
    scales.setHeight(1.9);
    scales.setDepth(26);
    scales.setWeight(0.99);
    scales.isMemory(false);
    scales.isAutoOffOn(true);
    scales.isVoiceHelp(false);
    scales.isChargeIndicator(true);
    scales.isIllumination(true);

    scales.print();

    return 0;
}
#endif
