using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba4
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
            
        public Candy(string title, int amount, int price)
        {
            this.title = title;
            this.amount = amount;
            this.price = price;
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
        protected int Price
        {
            get { return price; }
            set { price = value; }
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
            return "\0";
        }
    }
    sealed class Caramel : Candy, IPastry
    {
        protected string grade;
        
        public Caramel(string title, int amount, int price, string grade) : base(title, amount, price)
        {
            this.title = title;
            this.amount = amount;
            this.price = price;
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
        public CandyBox(string title, int amount, int price, string color) : base(title, amount, price)
        {
            this.title = title;
            this.amount = amount;
            this.price = price;
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
    }
    class ChocolateCandy : Candy, IPastry
    {
        protected int procent;
        public ChocolateCandy(string title, int amount, int price, int procent) : base(title, amount, price)
        {
            this.title = title;
            this.amount = amount;
            this.price = price;
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
    //class Cookie : Candy
    //{

    //}
}
