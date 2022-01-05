package com.company;

import java.util.Scanner;
import java.util.Arrays;

public class Main {

    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);
        int i, j, k, temp_int, array_size_x = 3, array_size_y = 3;
        int[][] array = new int[array_size_x][array_size_y];
        ThisExample class_1 = new ThisExample(2);
        String line_1 = new String();
        String line_2 = new String();

        for (i = 0; i < array_size_x; i++)
            for (j = 0; j < array_size_y; j++)
                array[i][j] = scanner.nextInt();

        for (i = 0; i < array_size_x; i++) {
            for (j = 0; j < array_size_y; j++)
                System.out.print(array[i][j] + " ");
            System.out.println();
        }
        System.out.println();

        for (k = 0; k < array_size_x; k++)
            for (i = 1; i < array_size_y; i++)
                if (array[k][i] > array[k][i - 1])
                    for (j = i; j > 0; j--)
                        if (array[k][j] > array[k][j - 1]) {
                            temp_int = array[k][j];
                            array[k][j] = array[k][j - 1];
                            array[k][j - 1] = temp_int;
                     }

        System.out.println("Array has been sorted in descending order: ");
        for (i = 0; i < array_size_x; i++) {
            for (j = 0; j < array_size_y; j++)
                System.out.print(array[i][j] + " ");
            System.out.println();
        }

        System.out.println("Which is greater: [0][0] or [0][1]: " + Helper.which_int_is_greater(array[0][0], array[0][1]));
        System.out.println("\nDifference between element [2][1] and private variable in ThisExample class: " + class_1.this_example_method(array[2][1]));

        scanner.nextLine();
        System.out.print("Enter a line: ");
        line_1 = scanner.nextLine();
        System.out.println("\nYour line: " + line_1);

        System.out.print("\nEnter another line. It will be compared with previous one: ");
        line_2 = scanner.nextLine();
        System.out.println("\nYour second line: " + line_2);

        System.out.print("Result of comparing: ");
        if (line_1.equals(line_2))
            System.out.println("equal");
        else System.out.println("not equal");

        String[] line_array = line_1.split(" ");
        System.out.println("String array was created from first line:");
        for (i = 0; i < line_array.length; i++)
            System.out.println(line_array[i]);

    }
}
