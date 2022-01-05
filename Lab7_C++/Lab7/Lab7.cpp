#include <iostream>
#include <conio.h>
#include <string>
#include "Class.h"

using namespace std;

int main()
{
    setlocale(LC_ALL, "RUS");

    ClassLab7 class1, class2;
    int ref(5), ptr(6);

    cout << class1.return_var() << endl;

    //Возврат по ссылке
    //Использование this в методе
    cout << "Возврат через ссылку: " << class1.return_ref_var(ref) << endl;
    //Возврат через указатель
    //Использование this в методе
    cout << "Возврат через указатель: " << class1.return_pointer_var(&ptr) << endl;
    //Возврат private поля через дружественную функцию класса
    cout << "Возврат private поля через дружественную функцию класса: " << return_private_data(class1) << endl;

    //Перегрузка префиксного инкримента
    class2 = ++class1;
    cout << "class2 = ++class1: class2:" << return_private_data(class2) << " class1" << return_private_data(class1) << endl;

    //Перегрузка постфиксного инкримента
    class2 = class1++;
    cout << "class2 = class1++: class2:" << return_private_data(class2) << " class1" << return_private_data(class1) << endl;

    ClassLab7 string;

    string.string_method();
}
