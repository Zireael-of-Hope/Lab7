using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_Sharp
{
    internal class Class
    {
        public int variable { get; private set; }

        public Class(int variable) {
            this.variable = variable;
        }

        //Используя ref мы передаем ссылку на переменную в метод, т.е. в методе мы работаем с самой переменной, а не с ее копией
        static public void PlusVariableOrNot_ref(Class classs, ref int variable_par) {
            Console.WriteLine("Do you want to add private variable to your int? (Yes - 1, No - 0)");

            int choice;
            bool pass;

            do {
                pass = false;
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 0 || choice == 1)
                    pass = true;
            } while (pass == false);

            switch (choice) {
                case 0:
                    break;
                case 1:
                    variable_par = +classs.variable;
                    break;
            }
        }

        //Аналогично ref
        //Но,используя out мы обязаны присвоить значение входному параметру с модификатором out
        static public void AssignPrivateVariableToInt(Class classs, out int variable_par)
        {
            variable_par = classs.variable;
        }

        //Перегрузка + для класса
        static public Class operator +(Class operator_1, Class operator_2) {
            return new Class(operator_1.variable + operator_2.variable);
        }

        //Перегрузка ++ для класса
        static public Class operator ++(Class operator_1)
        {
            operator_1.variable++;
            return operator_1;
        }
    }
}
