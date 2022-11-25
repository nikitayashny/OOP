using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba10
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] months = {
                "January",
                "February",
                "March",
                "April",
                "May",
                "June",
                "July",
                "August",
                "September",
                "October",
                "November",
                "December"
            };

            Console.WriteLine("Введите длину месяца: ");
            int n = Convert.ToInt32(Console.ReadLine());

            IEnumerable<string> lengthN = from month in months where month.Length == n select month;

            var WinterSummer = months.Where((month, i) => i < 2 || i > 4 && i < 8 || i == 11);
            var alphabetOrder = months.OrderBy(month => month);
            var withU = months.Where(month => month.Contains("u") && month.Length > 3);

            foreach (string s in lengthN)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();

            foreach (string s in WinterSummer)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();

            foreach (string s in alphabetOrder)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();

            foreach (string s in withU)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();


            List<Date> dates = new List<Date>() {
            new Date(10, 2, 2000),
            new Date(10, 2, 2001),
            new Date(11, 2, 2000),             
            new Date(15, 8, 2000),
            new Date(11, 2, 2001),
            new Date(20, 9, 2004),
            new Date(31, 1, 2004),
            new Date(15, 3, 1980),
            new Date(13, 5, 1980),
            new Date(24, 5, 2010)
            };
  
            var years = dates.Where(e => e.Year == 2000);
            var monthss = dates.Where(e => e.Month == 2);
            var count = dates.Where(e => e.Year > 1980 && e.Year < 2001).Count();
            var maxdate = dates.Max(e => (e.Year, e.Month, e.Day));
            var firstdate = dates.First(e => e.Day == 11);
            var sorted = dates.OrderBy(e => (e.Year, e.Month, e.Day));
            var birthday = dates.Where(e => e.Year == 2004).Where(e => e.Month == 1).Where(e => e.Day == 31);

            Console.WriteLine("Cписок дат для заданного года: ");
            foreach (var s in years)
            {
                s.Print();
            }    
            Console.WriteLine();

            Console.WriteLine("Список дат, которые имеют заданный месяц: ");
            foreach (var s in monthss)
            {
                s.Print();
            }
            Console.WriteLine();

            Console.WriteLine("Количество дат в определённом диапазоне:");
            Console.WriteLine(count);
            Console.WriteLine();

            Console.WriteLine("Максимальная дата:");
            Console.WriteLine(maxdate);
            Console.WriteLine();

            Console.WriteLine("Первая дата заданного дня:");
            firstdate.Print();
            Console.WriteLine();

            Console.WriteLine("Упорядоченный список дат (хронологически):");
            foreach (var s in sorted)
            {
                s.Print();
            }
            Console.WriteLine();

            Console.WriteLine("Свой запрос(день рождения)");
            foreach (var s in birthday)
            {
                s.Print();
            }
            Console.WriteLine();
        }   
    }
}
