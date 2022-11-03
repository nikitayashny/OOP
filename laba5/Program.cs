using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba5
{
    class Program
    {
        static void Main(string[] args)
        {
            ChildrensGift childrensgift = new ChildrensGift();
            Candy[] candies = { new CandyBox("Merci", 10, 350, 30, "синий"), new Caramel("Карамелька", 15, 100, 90, "высший"),
                                new ChocolateCandy("Аришка", 75, 3, 50, 34), new Cookie("Любовь", 40, 85, 20, false)};
            foreach (var i in candies)
            {
                childrensgift.addCandy(i);
            }
            childrensgift.Show();
            childrensgift.removeCandy(2);
            childrensgift.Show();

            Console.WriteLine($"Общий вес подарка: {Controller.GiftWeight(childrensgift)} г");
            Console.WriteLine(); Console.WriteLine("Отсортированный по цене список:"); Console.WriteLine();
            ChildrensGift childrengiftSorted = Controller.SugarSort(childrensgift);
            childrengiftSorted.Show();
            Console.WriteLine("Конфета с заданным содержанием сахара: " + Controller.FindCandy(childrensgift, 30));

            Console.WriteLine("\n\n- - - - - - - - Тест чтения файла - - - - - - - -");
            ChildrensGift container = new ChildrensGift();
            Controller.ReadFile(container, @"C:\Users\User\Desktop\ООП\laba5\laba5\ChildrensGift.txt");
            container.Show();
           
            Console.ReadKey();
        }
    }
}
