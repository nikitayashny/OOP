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
        }
    }
}
