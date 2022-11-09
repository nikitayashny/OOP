using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace laba6
{
    class Program
    {
        static void Main(string[] args)
        {
            ChildrensGift childrensgift = new ChildrensGift();
            Candy[] candies = { new CandyBox("Merci", 10, 350, 30, "синий"), new Caramel("Карамелька", 15, 100, 90, "высший"),
                                new ChocolateCandy("Аришка", 75, 3, 50, 34), new Cookie("Любовь", 40, 85, 20, false)};
            foreach (var i in candies)
            {
                childrensgift.addCandy(i);
            }
            //childrensgift.Show();
            //childrensgift.removeCandy(2);
            //childrensgift.Show();

            //Console.WriteLine($"Общий вес подарка: {Controller.GiftWeight(childrensgift)} г");
            //Console.WriteLine(); Console.WriteLine("Отсортированный по цене список:"); Console.WriteLine();
            //ChildrensGift childrengiftSorted = Controller.SugarSort(childrensgift);
            //childrengiftSorted.Show();
            //Console.WriteLine("Конфета с заданным содержанием сахара: " + Controller.FindCandy(childrensgift, 30));

            //Console.WriteLine("\n\n- - - - - - - - Тест чтения файла - - - - - - - -");
            //ChildrensGift container = new ChildrensGift();
            //Controller.ReadFile(container, @"C:\Users\User\Desktop\ООП\laba5\laba5\ChildrensGift.txt");
            //container.Show();

            try
            {
                int test = 2;
                Logger logger = new Logger();
                logger.FileLoggerWriteLine("Log-файл успешно создан");
                try
                {
                    ChildrensGift test1 = new ChildrensGift();
                    
                    CandyBox candy1 = new CandyBox("Merci", 10, 350, 30, "синий");
                    for(int i = 0; i < 10; i++)
                    {
                        test1.addCandy(candy1);
                    }
                    test1.removeCandy(100);
                    //candies[10].ToString();

                    //int test2 = 0;
                    //test2 /= 0;
                    //Debug.Assert(test <= 1 && test >= 0, "Значение testpr может быть только 0 или 1");
                }
                catch (DivideByZeroException exception) when (test != 1)
                {
                    logger.FileLoggerWriteError("Error NullReferenceException", exception.Message, exception.StackTrace);
                    logger.ConsoleLoggerError("Error NullReferenceException", exception.Message, exception.StackTrace);
                }
                catch (NullCollectionException exception)
                {
                    Console.WriteLine($"Произошла ошибка: {exception.Message}");
                }
                catch (MaxCollection exception) when (test != 1)
                {
                    logger.FileLoggerWriteError("Error Class MaxCollection", exception.Message, exception.StackTrace);
                    logger.ConsoleLoggerError("Error class MaxCollections", exception.Message, exception.StackTrace);
                }
                catch (MaxCollection exception)
                {
                    Console.WriteLine($"Произошла ошибка: {exception.Message}");
                }
                catch (DeleteNullObject exception)
                {
                    Console.WriteLine($"Произошла ошибка: {exception.Message}");
                }
                catch
                {
                    Console.WriteLine("Поиск возможной причины исключения");
                    throw;
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Попытка обращения к несуществующему элементу");
            }
            catch
            {
                Console.WriteLine("Исключение необработано");
            }
            finally
            {
                Console.WriteLine("Тест закончился");
            }

            Console.ReadKey();
        }
    }
}
