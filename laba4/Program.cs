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
            Caramel caramel1 = new Caramel("Карамелька", 15, 100, "высший");
            caramel1.Print();
            Console.WriteLine();
        }
    }
}