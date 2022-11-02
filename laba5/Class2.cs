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
    }
}
