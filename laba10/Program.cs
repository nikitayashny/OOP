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
        }
    }
}