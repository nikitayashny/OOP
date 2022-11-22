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
                List<string> list = new List<string>();

                Console.WriteLine(" - - - - - Вывод списка string - - - - - ");

                list.AddNode("yashny");
                list.AddNode("nikita");
                list.AddNode("sergeevich");
                list.ShowInfo();

                Console.WriteLine(" - - - - - Вывод списка без удалённого элемента - - - - - ");
                list.DeleteNode("sergeevich");
                //list.DeleteNode("Nikita");    // ошибка (не найден элемент)
                list.ShowInfo();

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