package com.company;

public class ThisExample {
    private int variable;

    public ThisExample(int variable) {
        this.variable = variable;
    }

    public int this_example_method(int variable) {
        variable = variable - this.variable;
        return variable;
    }
}
