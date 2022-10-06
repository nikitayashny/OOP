namespace laba2
{
    class Date
    {
        int day;
        int month;
        int year;
        string [] num = { "января", "февраля", "марта", "апреля", "мая", "июня", "июля", "августа", "сентября", "октября", "ноября", "декабря" };
        static int statDay;
        public static int StatDay => statDay;
        static Date() { statDay = 0; }
        public Date() { day = 31; month = 1; year = 2004; }
        public Date(int a) { day = a; month = 3; year = 1980; }
        public Date(int a, int b, int c) { day = a; month = b; year = c; }

        bool LeapYear(int year)
        {
            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
                return true;
            else
                return false;
        }
        bool Valid(int day, int month, int year)
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
        public void Print()
        {

            if (Valid(day, month, year))
            {
                Console.WriteLine("Выберите вариант вывода данных: 1 - 5 января 2018 года, 2 - 05/01/2018");
                int choose = Convert.ToInt32(Console.ReadLine());
                switch (choose)
                {
                    case 1: Console.WriteLine($"{day} {num[month - 1]} {year} года");
                        break;
                    case 2:
                        if (day < 10 && month > 9)
                            Console.WriteLine($"0{day}/{month}/{year}");
                        if (day > 9 && month < 10)
                            Console.WriteLine($"{day}/0{month}/{year}");
                        if (day < 10 && month < 10)
                            Console.WriteLine($"0{day}/0{month}/{year}");
                        if (day > 9 && month > 9)
                            Console.WriteLine($"{day}/{month}/{year}");
                        break;
                    default: Console.WriteLine("Некорректные данные");
                        break;
                }
            }
            else
                Console.WriteLine("Некорректные данные");
        }
    }
    class Program
    {
        static void Main()
        {
            Date MyBirthDate = new();
            Date MumsBirthDate = new(15);
            Date DadsBirthDate = new(13, 5, 1980);

            MyBirthDate.Print();
            MumsBirthDate.Print();
            DadsBirthDate.Print();

            Console.WriteLine("Вывод статического конструктора: " + Date.StatDay);
        }
    }
}