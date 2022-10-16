namespace laba2
{
    partial class Partial : Object
    {
        private readonly string name;
        public Partial(string name)
        {
            this.name = name;
        }
        public override int GetHashCode()
        {
            int hash = 0;
            Random rand = new Random();
            for (int i = 0; i < name.Length; i++)
            {
                hash += name[i];
            }
            hash *= rand.Next(1000, 999999);
            return (int)Math.Abs(hash * name.Length);
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override string ToString()
        {
            return name;
        }
    }

    class Lab2
    {
        public static int statDay;
        public readonly bool _a;
        public const double _b = 0.1;
        public static int counter = 0;

        static Lab2() { statDay = 0; }
        public Lab2(bool a) { _a = a; Console.WriteLine("Вывод поля readonly: " + _a); }
        private int c;
        private  int d;
        public Lab2() { counter++; }

        public int C {
            get { return c; } 
            set { c = value; }
        }

        public int D {
            get { return d; }
            private set { d = value; }
        }

        public static void Foo(ref int r)
        {
            Console.WriteLine("Вывод со свойством ref: " + r);
        }

        public static void FooO(out int r)
        {
            r = 0;
            Console.WriteLine("Вывод со свойством out: " + r);
        }
    }
    class Date
    {
        public int day;
        public int month;
        public int year;
        string [] num = { "января", "февраля", "марта", "апреля", "мая", "июня", "июля", "августа", "сентября", "октября", "ноября", "декабря" };
        

        public Date() { day = 31; month = 1; year = 2004; }
        public Date(int a) { day = a; month = 3; year = 1980; }
        public Date(int a, int b, int c) { day = a; month = b; year = c; }
        private Date(int a, int b) { day = a; month = b; year = 2000; }     // закрытый конструктор
     
 
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
            Date date1 = new(10, 2, 2000);
            Date date2 = new(10, 2, 2001);
            Date date3 = new(11, 2, 2000);
            Date date4 = new(15, 8, 2000);
            Date date5 = new(11, 2, 2001);
            Date date6 = new(20, 9, 2004);
            //Date PrvtConstrator = new(4, 10); 



            MyBirthDate.Print();
            MumsBirthDate.Print();
            DadsBirthDate.Print();
            //PrvtConstrator.Print();





            Console.WriteLine("Вывод статического конструктора: " + Lab2.statDay);
            Lab2 ro = new(true);
            Console.WriteLine("Вывод поля const: " + Lab2._b);





            Lab2 getset = new();
            getset.C = 10;
            int c = getset.C;
            Console.WriteLine("Вывод поля со свойствами get set: " + c);

            //getset.D = 20;            // ограничен доступ по set
            //int d = getset.D;





            int r = 2;
            Lab2.Foo(ref r);
            Lab2.FooO(out r);




            Console.WriteLine("Количество созданных объектов Lab2() без параметров: " + Lab2.counter);





            Partial name = new("Никита");
            Console.WriteLine("Хеш-код: " + name.GetHashCode());
            Console.WriteLine("Сравнение объектов: " + name.Equals("Nikita"));
            Console.WriteLine(name);




            Date [] dates = {date1, date2, date3, date4, date5, date6};
            int Year;
            Console.WriteLine("Введите год: "); Year = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < dates.Length; i++)
            {
                if (dates[i].year == Year)
                {
                    dates[i].Print();
                }
            }
            Console.ReadLine();
        }
    }
}
