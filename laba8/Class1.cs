using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace laba8
{
    class User
    {
        public delegate void UserDelegate(object obj);

        public event UserDelegate Move;
        public event UserDelegate Squeeze;

        public void move(object obj)
        {
            Console.WriteLine("Отработал move");
            Console.WriteLine("Задайте смещение");
            int num = int.Parse(Console.ReadLine());
            obj = num;
            obj.ToString();
            Move?.Invoke(obj);
        }
        public void squeeze(object obj)
        {
            Console.WriteLine("Отработал squeeze");
            Console.WriteLine("Задайте сжатие");
            int num = int.Parse(Console.ReadLine());
            obj.ToString();
            Squeeze?.Invoke(obj);
        }
    }
    class StringEditor
    {
        public static string RemovePunctuation(string str)
        {
            str = Regex.Replace(str, "[.,;:]", string.Empty);
            return str;
        }

        public static string AddSymbol(string str)
        {
            return str += "Laba8";
        }

        public static string ToUpper(string str)
        {
            return str.ToUpper();
        }

        public static string ToLower(string str)
        {
            return str.ToLower();
        }

        public static string RemoveSpace(string str)
        {
            return str.Replace(" ", string.Empty);
        }
    }
}
