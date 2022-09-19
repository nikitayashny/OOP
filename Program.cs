using System;
using System.Text;

namespace laba1
{
    class Program
    {
        static string _LineStr = "Поле с _";
        static void Main(string[] args)
        {
            //////////////////  Задание 1   /////////////////////                   

            //Инициализация переменных

            Console.WriteLine("//////////////////////////// Task 1 ////////////////////////////");

            bool boo = true;
            Console.WriteLine("bool: " + boo);          //хранит значение true или false

            byte by = 1;                                //Convert.ToByte(Console.ReadLine());
            Console.WriteLine("byte: " + by);           //хранит целое число от 0 до 255 и занимает 1 байт

            sbyte sby = 2;                              //Convert.ToSByte(Console.ReadLine());
            Console.WriteLine("sbyte: " + sby);         //хранит целое число от -128 до 127 и занимает 1 байт

            char ch = 'a';                              //Convert.ToChar(Console.Read());
            Console.WriteLine("char: " + ch);           //хранит одиночный символ в кодировке Unicode и занимает 2 байта

            decimal dec = 0.1m;                         //Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("decimal: " + dec);       //хранит десятичное дробное число. Если употребляется без десятичной запятой,
                                                        //имеет значение от ±1.0*10-28 до ±7.9228*1028, может хранить 28 знаков после
                                                        //запятой и занимает 16 байт

            double doubl = 0.2;                         //Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("double: " + doubl);      //хранит число с плавающей точкой от ±5.0*10-324 до ±1.7*10308 и занимает 8 байта

            float fl = 0.3f;                            //Convert.ToFloat(Console.ReadLine()); 
            Console.WriteLine("float: " + fl);          //хранит число с плавающей точкой от -3.4*1038 до 3.4*1038 и занимает 4 байта

            int inte = 3;                                  //Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("int: " + inte);             //хранит целое число от -2147483648 до 2147483647 и занимает 4 байта

            uint ui = 4;                                //Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("uint: " + ui);           //хранит целое число от 0 до 4294967295 и занимает 4 байта

            long l = 5;                                 //Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("long: " + l);            //хранит целое число от –9223372036854775808 до 9223372036854775807 и занимает 8 байт

            ulong ul = 6;                               //Convert.ToUInt64(Console.ReadLine());
            Console.WriteLine("ulong: " + ul);          //хранит целое число от 0 до 18446744073709551615 и занимает 8 байт

            short sh = 7;                               //Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("short: " + sh);          //хранит целое число от -32768 до 32767 и занимает 2 байта

            ushort ush = 8;                             //Convert.ToUInt16(Console.ReadLine());
            Console.WriteLine("ushort: " + ush);        //хранит целое число от 0 до 65535 и занимает 2 байта

            nint ni = 9;                                //Convert.ToInt32(Console.ReadLine());                               
            Console.WriteLine("nint: " + ni);           //Зависит от платформы, занимает от 4 до 8 байт

            nuint nui = 10;                             //Convert.ToUInt32(Console.ReadLine()); 
            Console.WriteLine("nuint: " + nui);         //Зависит от платформы, занимает от 4 до 8 байт

            string str = "stroka";
            Console.WriteLine("string: " + str);

            object obj = 5;
            Console.WriteLine("object: " + obj);

            dynamic dyn = 5;
            Console.WriteLine("dynamic: " + dyn);


            //Явные преобразования

            int transform = (int)by;
            int transform2 = (int)l;
            short transform3 = (short)by;
            ushort transform4 = (ushort)sby;
            byte transform5 = (byte)sby;

            //Неявные преобразования

            Console.WriteLine("///////////////////////////");

            byte bvalue = 1;
            short svalue = bvalue;
            int ivalue = svalue; 
            long lvalue = ivalue;
            float fvalue = lvalue;
            double dvalue = fvalue;

            //Упаковка и распаковка

            int variant = 1;
            object pack = variant;         //упаковка
            int unpack = (int)pack;       //распаковка

            //Работа с неявно типизированной переменной

            var imvar = 1;
            var imvar2 = new float[10];
            var imvar3 = "var";

            //Работа с Nullable

            string stri = null;
            object nullablevar = null;
            dynamic nullablevar2 = null;

            Nullable<int> varnot = null;
            int? varaible = null; // проще
            short? variable2 = null;
            long? variable3 = null;

            //var

            Console.WriteLine(varaible == null);
            Console.WriteLine(varaible.HasValue);
            Console.WriteLine(varaible.GetValueOrDefault(-1));
            Console.WriteLine(varaible ?? -2);

            int first = 24;
            int? result = first + varaible;
            bool firstboo = varaible > first;
            bool firstboo2 = varaible < first;
            bool firstboo3 = varaible == first;

            //Строки

            string str1 = "Первая строка";
            string str2 = "Втораяя строка";

            if (str1.Length > str2.Length)
            {
                Console.WriteLine("stro1 < stro2");
            }
            else if (str1.Length < str2.Length)
            {
                Console.WriteLine("stro2 > stro1");
            }
            else
            {
                Console.WriteLine("str1 == str2");
            }

            int comparestr = String.Compare(str1, str2);
            Console.WriteLine(comparestr);

            // сцепление, копирование, выделение подстроки, разделение строки на слова .....

            string Line1 = "Привет    Мир!!!";
            string Line2 = "Меня зовут Яшный Никита";
            string Line3 = "Мир";

            string Line00 = Line1 + Line3; // сцепление
            string Line01 = String.Concat(Line1, Line3); // -||-
            string Line02 = String.Join(' ', Line1, Line2, Line3); // -||-

            string Line10 = (string)Line1.Clone(); // копирование
            string Line11 = String.Copy(Line1); // -||- устаревшее
            char[] arr = new char[8];
            Line1.CopyTo(0, arr, 0, 7); // -||-

            string Line20 = Line1.Substring(0, 5); // выделение подстроки
            Console.WriteLine(Line1.Contains(Line3)); // -||-

            string[] Line30 = Line1.Split(' ', StringSplitOptions.RemoveEmptyEntries); // разделение на слова

            string Line40 = Line2.Insert(0, Line3); // вставка подстроки в заданную позицию

            string Line50 = Line2.Remove(0, 5); // удаление подстроки

            Console.WriteLine($"Вы вводили значения: Decimal - {dec}"); // интерполирование строк

            // метод String.IsNullOrEmpty

            string Line60 = null;
            string Line61 = "      ";

            Console.WriteLine(String.IsNullOrEmpty(Line60)); // true
            Console.WriteLine(String.IsNullOrEmpty(Line61)); // false
            Console.WriteLine(String.IsNullOrWhiteSpace(Line61)); // true

            // StringBuilder

            var text = new StringBuilder("Hello, World!!! My name's Nikita", 60);
            text.Remove(13, 2);
            text.Insert(0, "Mister, ");
            text.Replace("Nikita", "Никита");
            text.Append(", I am programmer");

            // Массивы

            int[,] matrix = new int[3, 3] { { 0, 1, 2 },
                                            { 3, 4, 5 },
                                            { 6, 7, 8 } };
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            // Массив string

            string[] arrSTR = new string[5] { "Петя", "Nikita", "Katya", "Masha", "Sasha" };
            foreach (string s in arrSTR)
            {
                Console.Write(s + " ");
            }
            Console.WriteLine("Длина массива{0}", arrSTR.Length);
            Console.WriteLine("Выберите элемент, который надо поменять: ");
            int check = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Введите строку: ");
            arrSTR[check] = Console.ReadLine();

            // Ступенчатый(зубчатый) массив

            float[] Arr01 = new float[2];
            float[] Arr02 = new float[3];
            float[] Arr03 = new float[4];
            float[][] Arr00 = new float[3][] { Arr01, Arr02, Arr03 };
            for (int i = 0; i < Arr00.Length; i++)
            {
                for (int j = 0; j < Arr00[i].Length; j++)
                {
                    Console.WriteLine("Y: {0} X: {1}", i, j);
                    Arr00[i][j] = int.Parse(Console.ReadLine());
                }
            }

            // Неявно типизированный массив

            var Arr20 = new[] { 1, 2, 3 };
            var Arr21 = new[] { "Pasha", "Kasper", "Mitya" };

            // Кортежи

            var kortezh1 = (1, "Masha", 'a', "Petya", (ulong)50);
            var kortezh2 = (1, 2);
            var kortezh3 = (1, 2);
            // (int, string, char, string, ulong) kortezh = (...);
            Console.WriteLine(kortezh1.Item1);
            Console.WriteLine(kortezh1.Item2);
            Console.WriteLine(kortezh1.Item3);
            Console.WriteLine(kortezh1.Item4);
            Console.WriteLine(kortezh1.Item5);

            Console.WriteLine(kortezh1.Item3);
            Console.WriteLine(kortezh1.Item5);

            (var kortezh21, var kortezh31) = ("sss", 25);
            var (kortrzh3, kortezh4) = (1, 5);
            int number0 = kortezh1.Item1;

            Console.WriteLine(kortezh3 == kortezh2);
            Console.WriteLine(kortezh3 != kortezh2);

            Console.WriteLine(_LineStr);

            // Локальная функция

            int[] arr22 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            string str99 = "NIKITA";
            (int, int, int, char) func(int[] arr, string line)
            {
                return (arr.Max(), arr.Min(), arr.Sum(), (char)line[0]);
            }
            var result2 = func(arr22, str99);

            // checked/ unchecked

            void func2()
            {
                checked
                {
                    int maxi = Int32.MaxValue;
                }
                return;
            }
            void func3()
            {
                unchecked
                {
                    int maxi = Int32.MaxValue;
                    maxi++;
                }
                return;
            }
            func2();
            func3();
        }
    }
}