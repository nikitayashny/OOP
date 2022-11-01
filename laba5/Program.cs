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


            IPastry candybox = new CandyBox("Merci", 10, 350, "синий");
            if (candybox is CandyBox)
            {
                candybox = candybox as CandyBox;
                candybox.ToString();
                candybox.GetHashCode();
                candybox.Official();
                candybox.Equals(candybox);
                Console.WriteLine();
            }

            Candy caramel = new Caramel("Карамелька", 15, 100, "высший");
            Candy chocolatecandy = new ChocolateCandy("Аришка", 75, 3, 34);
            Candy cookie = new Cookie("Любовь", 40, 85, false);
            Cookie? Cookie1 = cookie as Cookie;

            Candy[] candies = { caramel, chocolatecandy, cookie };
            Console.WriteLine("Вызов метода IAmPrinting"); Console.WriteLine();
            Printer printer = new Printer();
            foreach (var item in candies)
            {
                printer.IAmPrinting(item);
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
