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
