#include "Class.h"

ClassLab7::ClassLab7(){
	variable = 2;
}

int ClassLab7::return_ref_var(int& variable) {
	variable = variable - this->variable;
	return variable;
}

int ClassLab7::return_pointer_var(int* variable) {
	*variable = *variable - this->variable;
	return *variable;
}

ClassLab7 ClassLab7::operator+(const ClassLab7& other) {
	ClassLab7 temp;
	temp.variable = this->variable + other.variable;
	return temp;
}

ClassLab7& ClassLab7::operator++() {
	this->variable++;
	return *this;
}

ClassLab7& ClassLab7::operator++(int value) {
	ClassLab7 temp;
	temp.variable = this->variable++;
	return temp;
}

void ClassLab7::string_method() {

	string line, line_1;

	cout << "Enter the line: ";
	getline(cin, line);
	
	cout << "Size() = " << line.size() << endl;

	cout << "Resize(): ";
	line.resize(10, '!');
	cout << line << "  line was resized to 10 symbols (if there were less then 10 syblos, '!' were added)" << endl;

	cout << "Enter another line: ";
	getline(cin, line_1);

	line.insert(3, line_1);
	cout << "Insert() string 2 has been inserted in string 1 after 3 symbol: " << line << endl;

	line.clear();
	cout << "Clear() string 1 has been cleared: " << line;
}

int return_private_data(ClassLab7& a) {
	return a.variable;
}


