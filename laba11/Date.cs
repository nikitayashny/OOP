using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba11
{
    class Lab2
    {
        public static int statDay;
        public readonly bool _a;        // поле только для чтения 
        public const double _b = 0.1;   // поле константа
        public static int counter = 0;

        static Lab2() { statDay = 0; }  // статический конструктор
        public Lab2(bool a) { _a = a; Console.WriteLine("Вывод поля readonly: " + _a); }    // вывод поля readonly
        private int c;  // поля для get set
        private int d;
        public Lab2() { counter++; }   // поле хранящее количество количество созданных объектов 

        public int C
        {
            get { return c; }
            set { c = value; }
        }

        public int D
        {
            get { return d; }
            private set { d = value; }
        }
    }
    class Date
    {
        public int day;
        public int month;
        public int year;
        string[] num = { "января", "февраля", "марта", "апреля", "мая", "июня", "июля", "августа", "сентября", "октября", "ноября", "декабря" };
        public Date() { day = 31; month = 1; year = 2004; }                 // конструктор класса без параметров
        public Date(int a) { day = a; month = 3; year = 1980; }             // конструктор класса с одним параметром

        public Date(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }
        public int Year
        {
            get
            {
                return year;
            }
            set
            {
                year = value;
            }
        }

        public int Month
        {
            get
            {
                return month;
            }
            set
            {
                month = value;
            }
        }

        public int Day
        {
            get
            {
                return day;
            }
            set
            {
                day = value;
            }
        }



        bool LeapYear(int year)                                             // метод проверки високосного года
        {
            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
                return true;
            else
                return false;
        }

        bool Valid(int day, int month, int year)                            // метод проверки корректности ввода данных
        {
            if (day < 1)
                return false;
            if (month > 12 || month < 1)
                return false;
            if ((month % 2 != 0 && month != 9 && month != 11 || month == 8 || month == 10 || month == 12) && day > 31)
                return false;
            if ((month % 2 == 0 && month != 8 && month != 10 && month != 12 && month != 2 || month == 11 || month == 9) && day > 30)
                return false;
            if (month == 2 && LeapYear(year) && day > 29)
                return false;
            if (month == 2 && !LeapYear(year) && day > 28)
                return false;
            return true;
        }

        public void Print()                                                 // метода вывода 
        {
            if (Valid(day, month, year))
            {
                Console.WriteLine($"{day} {num[month - 1]} {year} года");
            }
            else
                Console.WriteLine("Некорректные данные");
        }
    }
}
