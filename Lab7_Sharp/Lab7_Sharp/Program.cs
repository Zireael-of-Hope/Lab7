using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Lab7_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Работа с массивом

            int i, j, k, temp_int, array_size_x = 3, array_size_y = 3;
            int[,] array = new int[array_size_x, array_size_y];

            Console.WriteLine("Enter double array one elemnt by one: ");
            for (i = 0; i < array_size_x; i++)
                for (j = 0; j < array_size_y; j++)
                    array[i, j] = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i < array_size_x; i++)
            {
                for (j = 0; j < array_size_y; j++)
                    Console.Write(array[i, j] + " ");
                Console.WriteLine();
            }
            Console.WriteLine();

            for (k = 0; k < array_size_x; k++)
                for (i = 1; i < array_size_y; i++)
                    if (array[k, i] > array[k, i - 1])
                        for (j = i; j > 0; j--)
                            if (array[k, j] > array[k, j - 1])
                            {
                                temp_int = array[k, j];
                                array[k, j] = array[k, j - 1];
                                array[k, j - 1] = temp_int;
                            }

            Console.WriteLine("Array has been sorted in descending order: ");
            for (i = 0; i < array_size_x; i++)
            {
                for (j = 0; j < array_size_y; j++)
                    Console.Write(array[i, j] + " ");
                Console.WriteLine();
            }

            Class class_1 = new(2);
            Class class_2 = new(4);

            int example_variable = 0;

            // out и ref

            //Можем изменить зачение, а можем не менять
            Class.PlusVariableOrNot_ref(class_1, ref example_variable);
            Console.WriteLine("\nNew value: " + example_variable);

            //Обязаны изменить значение
            Class.AssignPrivateVariableToInt(class_1, out example_variable);
            Console.WriteLine("\nNew value: " + example_variable);

            //Перегрузка операторов

            class_1++;
            Console.WriteLine("\nClass private variable new value: " + class_1.variable);

            Class class_3 = class_1 + class_2;
            Console.WriteLine("\nClass private variable new value: " + class_3.variable);

            //Строки

            string line_1, line_2;

            Console.Write("Enter a line: ");
            line_1 = Console.ReadLine();
            Console.WriteLine("\nYour line: " + line_1);

            Console.Write("\nEnter another line. It will be compared with previous one: ");
            line_2 = Console.ReadLine();
            Console.WriteLine("\nYour second line: " + line_2);

            Console.Write("\nResult of comparing: ");
            if (line_1 == line_2)
                Console.WriteLine("equal");
            else Console.WriteLine("not equal");

            String[] line_array = line_1.Split(" ");
            Console.WriteLine("\nString array was created from first line:");
            for (i = 0; i < line_array.Length; i++)
                Console.WriteLine(line_array[i]);


            //Struct

            Struct hello = new(2);
            hello++;
            Console.WriteLine(hello.Variable);
        }
    }
}