using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba8
{
    class Program
    {
        static void Main(string[] args)
        {
            User.UserDelegate subs1;
            User.UserDelegate subs2;
            User user = new User();

            int Obj1 = 2004;
            string Obj2 = "Obj2";
            char Obj3 = 'a';

            user.Move += obj =>
            {            
                Console.WriteLine($"Объект {obj} подписан на Move");
                Console.WriteLine();
            };

            user.Squeeze += obj =>
            {
                
                Console.WriteLine($"Объект {obj} подписан на Squeeze");
                Console.WriteLine();
            };

            subs1 = user.move;
            subs1 += user.squeeze;
            subs1 += user.squeeze;

            subs2 = user.move;

            subs1(Obj1);
            subs2(Obj2);
            subs2(Obj3);

            Console.WriteLine("Проверяем состояния объектов:");
            Console.WriteLine($"{Obj1} {Obj2} {Obj3}");
        }
    }
}