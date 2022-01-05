#pragma once
#include <iostream>
#include <string>
using namespace std;

class ClassLab7 {
private:
	int variable;
public:
	int& return_var() {
		return variable;
	}

	ClassLab7();
	int return_ref_var(int& variable);
	int return_pointer_var(int* variable);

	friend int return_private_data(ClassLab7& a);

	ClassLab7 operator +(const ClassLab7& other);
	ClassLab7& operator ++();
	ClassLab7& operator ++(int value);

	void string_method();
};

