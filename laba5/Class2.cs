using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba5
{
    partial class Cookie
    {
        public override string ToString()
        {
            base.ToString();
            if (gluten == true)
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
    class ChildrensGift
    {
        private readonly List<Candy>? ListCandy;
        public List<Candy>? GetList
        {
            get;
            set;
        }
        public ChildrensGift()
        {
            ListCandy = new List<Candy>();
        }
        public void addCandy(Candy obj)
        {
            ListCandy.Add(obj);
        }
        public bool removeCandy(int position)
        {
            if (position < ListCandy.Count)
            {
                Console.WriteLine($"Элемент {position} удалён");
                ListCandy.RemoveAt(position - 1);
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Show()
        {
            Console.WriteLine("----Список----"); Console.WriteLine();
            foreach (Candy obj in ListCandy)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("--------------");
        }
        public System.Collections.IEnumerator GetEnumerator()
        {
            return ListCandy.GetEnumerator();
        }
    }
    class Controller 
    {
        public static int GiftWeight(ChildrensGift ListCandy)
        {
            int weight = 0;
            foreach (var i in ListCandy)
            {
                if (i is CandyBox)
                {
                    weight += 1000;
                }
                if (i is Caramel)
                {
                    weight += 300;
                }
                if (i is ChocolateCandy)
                {
                    weight += 200;
                }
                if (i is Cookie)
                {
                    weight += 1500;
                }
            }
            return weight;
        }
        public static ChildrensGift SugarSort(ChildrensGift ListCandy) 
        {
            int size = 0;
            int counter = 0;

            foreach (var i in ListCandy)
            {
                size++;
            }

            Candy[] arr = new Candy[size]; 
            foreach (Candy i in ListCandy)
            {
                arr[counter] = i;
                counter++;
            }

            Candy temp;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j].Price < arr[j + 1].Price)
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;    
                    }
                }
            }
            
            ChildrensGift childrensGift = new ChildrensGift();
            
            for (int i = 0; i < arr.Length; i++)
            {
                childrensGift.addCandy(arr[i]);
            }
            return childrensGift;
        }
        public static string FindCandy(ChildrensGift ListCandy, int procent)
        {
            string str = "Конфеты с заданным содержанием сахара нет";
            foreach (Candy i in ListCandy)
            {
                if (i.Sugarprocent == procent)
                {
                    str = i.Title.ToString();
                }
            }
            return str;
        }
        public static void ReadFile(ChildrensGift collection, string patch)
        {
            string[] textFile = System.IO.File.ReadAllLines(patch);
            for (int i = 0; i < textFile.Length; i++)
            {
                string[] dwordLine = textFile[i].Split(' ');
                switch (dwordLine[0])
                {
                    case "CandyBox":
                        collection.addCandy(new CandyBox(dwordLine[1], Convert.ToInt32(dwordLine[2]), Convert.ToInt32(dwordLine[3]), Convert.ToInt32(dwordLine[4]), dwordLine[5]));
                        break;
                    case "Caramel":
                        collection.addCandy(new Caramel(dwordLine[1], Convert.ToInt32(dwordLine[2]), Convert.ToInt32(dwordLine[3]), Convert.ToInt32(dwordLine[4]), dwordLine[5]));
                        break;
                    case "ChocolateCandy":
                        collection.addCandy(new ChocolateCandy(dwordLine[1], Convert.ToInt32(dwordLine[2]), Convert.ToInt32(dwordLine[3]), Convert.ToInt32(dwordLine[4]), Convert.ToInt32(dwordLine[5])));
                        break;
                    case "Cookie":
                        collection.addCandy(new Cookie(dwordLine[1], Convert.ToInt32(dwordLine[2]), Convert.ToInt32(dwordLine[3]), Convert.ToInt32(dwordLine[4]), Convert.ToBoolean(dwordLine[5])));
                        break;
                }
            }
        }
    }
}
