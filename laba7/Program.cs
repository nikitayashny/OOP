using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba7
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<string> strlist = new List<string>();
                Console.WriteLine(" - - - - - Вывод списка string - - - - - ");

                strlist.AddNode("yashny");
                strlist.AddNode("nikita");
                strlist.AddNode("sergeevich");
                strlist.ShowInfo();

                Console.WriteLine(" - - - - - Вывод списка без удалённого элемента - - - - - ");
                strlist.DeleteNode("sergeevich");
                //list.DeleteNode("Nikita");    // ошибка (не найден элемент)
                strlist.ShowInfo();
                Console.WriteLine("Количество элементов списка string: " + StaticOperations.Count(strlist));


                List<int> intlist = new List<int>();
                Console.WriteLine(" - - - - - Вывод списка инт - - - - - ");
                
                intlist.AddNode(1);
                intlist.AddNode(2);
                intlist.AddNode(3);
                intlist.ShowInfo();

                Console.WriteLine(" - - - - - Вывод списка без удалённого элемента - - - - - ");
                intlist.DeleteNode(2);
                intlist.FoundNode(1);
                intlist.ShowInfo();

                Caramel caramel1 = new Caramel("Карамель1", 10, 100, "Высший");
                Caramel caramel2 = new Caramel("Карамель2", 5, 50, "Средний");
                Caramel caramel3 = new Caramel("Карамель3", 20, 10, "Низший");

                Console.WriteLine(" - - - - - Вывод списка Caramel - - - - - ");
                List<Caramel> listCheck = new List<Caramel>();
                listCheck.AddNode(caramel1);
                listCheck.AddNode(caramel2);
                listCheck.AddNode(caramel3);
                listCheck.ShowInfo();
                Console.WriteLine(" - - - - - Вывод списка без удалённого элемента - - - - - - - ");
                listCheck.DeleteNode(caramel3);
                listCheck.ShowInfo();
                Console.WriteLine("Количество элементов списка Check " + StaticOperations.Count(listCheck));
            }
            catch (DeleteNotFounded exception)
            {
                Console.WriteLine(exception.Message);
            }
            finally
            {
                Console.WriteLine("Тест закончился");
            }
        }
    }
}
