using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_Sharp
{
    //Структура в отлчие от класса значимый тип, а не ссылочный
    internal struct Struct
    {
        public int Variable { get; private set; }
        private int Variable_2;

        //Конструктор Struct в отличие от Class обязан определять все поля до возврата
        public Struct(int variable) { 
            Variable = variable;
            Variable_2 = ++variable;
        }

        public static Struct operator ++(Struct operator1) {
            operator1.Variable++;
            return operator1;
        }
    }
}
