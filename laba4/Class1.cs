using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba4
{
    interface IPastry
    {
        void Print();
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

        public virtual void Print()
        {
            Console.WriteLine("Информация о товаре:");
            Console.WriteLine($"Название: {title}");
            Console.WriteLine($"Количество: {amount}");
            Console.WriteLine($"Цена: {price}");
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

        public new void Print()
        {
            base.Print();
            Console.WriteLine($"Сорт карамели: {grade}");
        }
    }
    //class CandyBox : Candy
    //{

    //}
    //class ChocolateCandy : Candy
    //{

    //}
    //class Cookie : Candy
    //{

    //}
}