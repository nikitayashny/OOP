using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba11
{
    public class Developer
    {
        public int Salary;
        public int Level;
        public int Wallet;

        public Developer(int salar, int level, int wallet)
        {
            Salary = salar;
            Level = level;
            Wallet = wallet;
        }
        public Developer()
        {
            Salary = 0;
            Level = 0;
            Wallet = 0;
        }

        public void Work(int wall)
        {
            Console.WriteLine("Работаю!");
            Wallet += 10_000;
            wall = Wallet;
        }
        public void OnDownSalary()
        {
            Console.WriteLine("Зарплата разработчика понижена");
            if (Salary >= 100)
            {
                Salary -= 100;
            }
            else
            {
                Salary = 0;
            }
        }
        public void OnUpLevel()
        {
            Console.WriteLine("Повышение");
            Level++;
        }
        public override string ToString()
        {
            return $"Разработчик: Зарплата = {Salary}, Кошелёк = {Wallet}, Зарплата = {Salary}, Уровень = {Level}";
        }
    }
}