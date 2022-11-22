using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba7
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
            Console.WriteLine($"Название: {Title}");
            Console.WriteLine($"Количество: {Amount}");
            Console.WriteLine($"Цена: {Price} руб.");
            return "\0";
        }
    }
    sealed class Caramel : Candy, IPastry
    {
        private string grade;
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
            string str = $"Caramel {title} {amount} {price} {grade}";
            return str;
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
            Console.WriteLine($"Цвет коробок: {Color}");
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
            Console.WriteLine($"Процент содержания какао: {Procent}%");
            return "\0";
        }
        public override void Official()
        {
            base.Official();
        }
    }
    class Cookie : Candy, IPastry
    {
        protected bool gluten;
        protected string glutenstr = " ";
        public Cookie(string title, int amount, int price, bool gluten) : base(title, amount, price)
        {
            this.title = title;
            this.amount = amount;
            this.price = price;
            this.gluten = gluten;
        }

        public bool Gluten
        {
            get { return gluten; }
            set { gluten = value; }
        }
        public override string ToString()
        {
            base.ToString();
            if (Gluten == true)
            {
                glutenstr = "да";
            }
            else
            {
                glutenstr = "нет";
            }
            Console.WriteLine($"Содержание глютена: {glutenstr}");
            return "\0";
        }
        public override void Official()
        {
            Console.WriteLine("<< Очень вкусное печенье >>");
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
    class Streams<T> where T : class
    {
        public static void InFile(ref List<T> list, string patch)
        {
            Node<T> node = list.Head;
            string str2 = "";
            using (StreamWriter sw = new StreamWriter(patch, false, Encoding.Default))
            {
                while (node != null)
                {
                    if (node.Info is Caramel)
                    {
                        str2 = node.Info.ToString() + "\n";
                        sw.WriteLine(str2);
                        node = node.Next;

                    }
                    else if (node.Info is int)
                    {
                        str2 = $"int {node.Info}\n";
                        sw.WriteLine(str2);
                        node = node.Next;

                    }
                    else if (node.Info is string)
                    {
                        str2 = $"string {node.Info}\n";
                        sw.WriteLine(str2);
                        node = node.Next;

                    }
                }

            }

        }


        public static void ReadFile(ref List<Caramel> collection1, ref List<string> collection2, ref List<int> collection3, string patch)
        {
            string[] textFile = System.IO.File.ReadAllLines(patch);
            for (int i = 0; i < textFile.Length; i++)
            {
                string[] dwordLine = textFile[i].Split(' ');
                switch (dwordLine[0])
                {
                    case "Caramel":
                        collection1.AddNode(new Caramel(dwordLine[1], Convert.ToInt32(dwordLine[2]), Convert.ToInt32(dwordLine[3]), dwordLine[4]));
                        break;
                    case "string":
                        collection2.AddNode(dwordLine[1]);
                        break;
                    case "int":
                        collection3.AddNode(Convert.ToInt32(dwordLine[1]));
                        break;
                }
            }
        }

    }
}
