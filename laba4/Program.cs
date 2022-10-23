using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba4
{
    class Program
    {
        static void Main(string[] args)
        {
            Candy Caramel1 = new Caramel("Карамелька", 15, 100, "высший");
            Caramel caramel1 = Caramel1 as Caramel;
            if (caramel1 is Caramel)
            {
                caramel1.ToString();
                caramel1.Official();
            }        
            Console.WriteLine();

            IPastry candybox1 = new CandyBox("Merci", 10, 350, "синий");
            if (candybox1 is CandyBox)
            {
                candybox1.ToString();
                candybox1.Official();
            }
            Console.WriteLine();

            Candy chocolatecandy = new ChocolateCandy("Аришка", 75, 3, 34);
            if (chocolatecandy is ChocolateCandy chocolatecandy1)
            {
                chocolatecandy1.ToString();
                chocolatecandy1.Official();
            }
            Console.WriteLine();

            Cookie cookie1 = new Cookie("Любовь", 40, 85, false);
            cookie1.ToString();
            cookie1.Official();
        }
    }
}
