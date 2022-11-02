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
            Candy[] candies = { new CandyBox("Merci", 10, 350, "синий"), new Caramel("Карамелька", 15, 100, "высший"),
                              new ChocolateCandy("Аришка", 75, 3, 34), new Cookie("Любовь", 40, 85, false)};
            foreach (var i in candies)
            {
                childrensgift.addCandy(i);
            }
            childrensgift.Show();
            childrensgift.removeCandy(2);
            childrensgift.Show();
        }
    }
}
