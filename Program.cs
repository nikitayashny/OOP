namespace laba1
{
    class Program
    {
        static void Main()
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

            int i = 3;                                  //Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("int: " + i);             //хранит целое число от -2147483648 до 2147483647 и занимает 4 байта

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

            //Явные преобразования

            Console.WriteLine("///////////////////////////");

            int a1 = 5; int b1 = 10;
            byte c1 = (byte)(a1 + b1);
            Console.WriteLine("Явное преобразование интов в байт: " + c1);

            long a2 = 3; long b2 = 4;
            short c2 = (short)(a2 + b2);
            Console.WriteLine("Явное преобразование лонгов в шорт: " + c2);

            int a3 = 5; long b3 = 34;
            short c3 = (short)(a3 + b3);
            Console.WriteLine("Явное преобразование инта и лонга в шорт: " + c3);

            short a4 = 1; short b4 = 1;
            byte c4 = (byte)(a4 + b4);
            Console.WriteLine("Явное преобразование шортов в байт: " + c4);

            long a5 = 5; long b5 = 19;
            int c5 = (int)(a5 + b5);
            Console.WriteLine("Явное преобразование лонгов в инт: " + c5);

            //Неявные преобразования

            Console.WriteLine("///////////////////////////");

            byte a6 = 1;

            short b6 = a6;
            Console.WriteLine("Неявное преобразование байт в шорт: " + b6);

            int c6 = b6; 
            Console.WriteLine("Неявное преобразование шорт в инт: " + c6);

            long d6 = c6;
            Console.WriteLine("Неявное преобразование инт в лонг: " + d6);
            
            float f6 = d6; 
            Console.WriteLine("Неявное преобразование лонг во флот: " + f6);
            
            double g6 = f6;
            Console.WriteLine("Неявное преобразование флот в дабл: " + g6);
        }
    }
}