using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace laba9
{
    class Programm
    {
        static void Main(string[] args)
        {
            Plant tree = new Plant("Дерево");
            Plant flower = new Plant("Цветок");
            Plant grass = new Plant("Трава");
            Plant bush = new Plant("Куст");

            MyCollection<Plant> plants = new MyCollection<Plant>() { tree, flower, grass, bush};

            plants.ShowCollection();
            Console.WriteLine();
            plants.Delete(grass);
            plants.ShowCollection();
            Console.WriteLine();
            plants.Search(flower);
            plants.Add(grass);
            plants.ShowCollection();
            Console.WriteLine();

            HashSet<int> evenNumbers = new HashSet<int>();
            HashSet<int> oddNumbers = new HashSet<int>();

            for (int i = 0; i < 5; i++)
            {
                evenNumbers.Add(i * 2);
                oddNumbers.Add((i * 2) + 1);
            }

            Console.Write("evenNumbers содержит {0} элементов: ", evenNumbers.Count);
            DisplaySet(evenNumbers);
            Console.Write("oddNumbers содержит {0} элементов: ", oddNumbers.Count);
            DisplaySet(oddNumbers);

            HashSet<int> allNumbers = new HashSet<int>(evenNumbers);

            Console.WriteLine();
            Console.WriteLine("Объединение evenNumbers с oddNumers...");
            allNumbers.UnionWith(oddNumbers);

            Console.Write("allNumbers содержит {0} элементов: ", allNumbers.Count);
            DisplaySet(allNumbers);

            allNumbers.Remove(5);
            Console.WriteLine();
            Console.Write("Коллекция без удалённого элемента:");
            DisplaySet(allNumbers);
            Console.WriteLine("allNumbers содержит {0} элементов", allNumbers.Count);

            void DisplaySet(HashSet<int> collection)
            {
                Console.Write("{");
                foreach (int i in collection)
                {
                    Console.Write(" {0}", i);
                }
                Console.WriteLine(" }");
            }

            Console.WriteLine();

            Dictionary<int, int> dict = new Dictionary<int, int>();

            foreach (var item in allNumbers)
            {
                dict.Add(item, item);
            }
            foreach (var pair in dict)
            {
                Console.WriteLine($"ключ {pair.Key}, значение {pair.Value}");
            }

            int pair2;

            if (dict.TryGetValue(6, out pair2))
            {
                pair2 = dict[6];
                Console.WriteLine($"объект :{pair2}- найден");
            }
            
        }
    }
}
