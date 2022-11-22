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
                List<Caramel> listCaramel = new List<Caramel>();

                listCaramel.AddNode(caramel1);
                listCaramel.AddNode(caramel2);
                listCaramel.AddNode(caramel3);
                listCaramel.ShowInfo();

                Console.WriteLine(" - - - - - Вывод списка без удалённого элемента - - - - - - - ");
                listCaramel.DeleteNode(caramel3);
                listCaramel.ShowInfo();
                Console.WriteLine("Количество элементов списка Check " + StaticOperations.Count(listCaramel));

                Console.WriteLine("------------------------------------------");
                List<Caramel> listCaramel2 = new List<Caramel>();

                //listCaramel2.AddNode(caramel1);
                //listCaramel2.AddNode(caramel2);
                //listCaramel2.AddNode(caramel3);

                //Console.WriteLine(listCaramel == listCaramel2);

                List<Caramel> list1 = new List<Caramel>();
                List<string> list2 = new List<string>();
                List<int> list3 = new List<int>();

                Streams <Caramel>.ReadFile(ref list1, ref list2, ref list3, @"C:\Users\User\Desktop\ООП\laba7\laba7\out.txt");
                Console.WriteLine("-------------------------------------------Вывод считанных данных");
                list1.ShowInfo();
                list2.ShowInfo();
                list3.ShowInfo();


                List<Caramel> list4 = new List<Caramel>();

                list4.AddNode(new Caramel("Caramel1", 10, 100, "high"));
                list4.AddNode(new Caramel("Caramel2", 5, 50, "middle"));
                list4.AddNode(new Caramel("Caramel3", 20, 10, "low"));

                Console.WriteLine("------------------------------------------- Данные которые запишутся в файл");
                list4.ShowInfo();
                Streams<Caramel>.InFile(ref list4, @"C:\Users\User\Desktop\ООП\laba7\laba7\in.txt");          
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
