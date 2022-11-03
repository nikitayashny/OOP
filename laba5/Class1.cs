using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba5
{
    interface IPastry
    {
        void Official();
        string ToString();
    }

    abstract class Candy
    {
        protected string title;
        protected int amount;
        protected int price;
        protected int sugarprocent;
       
        enum Availability
        {
            notavail = 0,
            avail
        }
        struct CheckAvail
        {    
            static Availability Avail = Availability.avail;
            public static string Check()
            {
                if (Avail == Availability.avail)
                {
                    return "Есть в наличии";
                }
                else
                {
                    return "Нет в наличии";
                }
            }
        }

        public Candy(string title, int amount, int price, int sugarprocent)
        {
            this.title = title;
            this.amount = amount;
            this.price = price;
            this.sugarprocent = sugarprocent;
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public int Amount
        {
            get { return amount; }
            set { amount = value; }
        }
        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        public int Sugarprocent
        {
            get { return sugarprocent; }
            set { sugarprocent = value; }
        }

        public virtual void Official()
        { 
            Console.WriteLine("<< Пройдена проверка на качество >>");
        }
        public override string ToString()
        {
            Console.WriteLine("----Информация о товаре----");
            Console.WriteLine($"Название: {title}");
            Console.WriteLine($"Количество: {amount}");
            Console.WriteLine($"Цена: {price} руб.");
            Console.WriteLine($"Процент содержания сахара: {sugarprocent}");
            Console.WriteLine($"Состояние: {CheckAvail.Check()}");
            return "\0";
        }
    }
    sealed class Caramel : Candy, IPastry
    {
        private string grade;
        public Caramel(string title, int amount, int price, int sugarprocent, string grade) : base(title, amount, price, sugarprocent)
        {
            this.title = title;
            this.amount = amount;
            this.price = price;
            this.sugarprocent = sugarprocent;
            this.grade = grade;
        }

        public string Grade
        {
            get { return grade; }
            set { grade = value; }
        }

        public override string ToString()
        {
            base.ToString();
            Console.WriteLine($"Сорт карамели: {grade}");
            return "\0";
        }
        public override void Official()
        {
            base.Official();
        }
    }
    class CandyBox : Candy, IPastry
    {
        protected string color;
        public CandyBox(string title, int amount, int price, int sugarprocent, string color) : base(title, amount, price, sugarprocent)
        {
            this.title = title;
            this.amount = amount;
            this.price = price;
            this.sugarprocent = sugarprocent;
            this.color = color;
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public override string ToString()
        {
            base.ToString();
            Console.WriteLine($"Цвет коробок: {color}");
            return "\0";
        }
        public override void Official()
        {
            base.Official();
        }
        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            Console.WriteLine("Артикул: " + color.GetHashCode());
            return 0;
        }
    }
    class ChocolateCandy : Candy, IPastry
    {
        protected int procent;
        public ChocolateCandy(string title, int amount, int price, int sugarprocent, int procent) : base(title, amount, price, sugarprocent)
        {
            this.title = title;
            this.amount = amount;
            this.price = price;
            this.sugarprocent = sugarprocent;
            this.procent = procent;
        }

        public int Procent
        {
            get { return procent; }
            set { procent = value; }
        }
        public override string ToString()
        {
            base.ToString();
            Console.WriteLine($"Процент содержания какао: {procent}%");
            return "\0";
        }
        public override void Official()
        {
            base.Official();
        }
    }
    partial class Cookie : Candy, IPastry
    {
        protected bool gluten;
        protected string glutenstr = " ";
        public Cookie(string title, int amount, int price, int sugarprocent, bool gluten) : base(title, amount, price, sugarprocent)
        {
            this.title = title;
            this.amount = amount;
            this.price = price;
            this.sugarprocent = sugarprocent;
            this.gluten = gluten;
        }

        public bool Gluten
        {
            get { return gluten; }
            set { gluten = value; }
        }
    }
    class Printer
    {
        public virtual void IAmPrinting(Candy candies)
        {
            Console.WriteLine($"\t{candies.GetType().Name}");
            candies.ToString();
            candies.Official();
        }
    }
}
