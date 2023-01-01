using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace laba15
{
        private static void Task1()
        {
            var task = new Task(() =>
            {
                multiplicationMatrix(20);
            });
            Console.WriteLine("ID задачи: " + task.Id);
            Console.WriteLine("Статус задачи до выполнения: " + task.Status);
            var sw = new Stopwatch();
            task.Start();
            sw.Start();
            Console.WriteLine("Статус задачи во время выполнения: " + task.Status);
            task.Wait();
            sw.Stop();
            Console.WriteLine("Время выполнения: " + sw.Elapsed);//затраченное время
            sw.Restart();
            Console.WriteLine("Статус задачи после выполнения: " + task.Status);
            Console.WriteLine("Время выполнения: " + sw.Elapsed + "\n");//затраченное время
        }
        private static void Task3()
        {
            CancellationTokenSource tokenSource = new CancellationTokenSource();
            CancellationToken token = tokenSource.Token;
            var task = new Task(() =>
            {
                multiplicationMatrix(20);
            }, token);
            task.Start();
            try
            {
                tokenSource.Cancel();
                task.Wait();
            }
            catch (AggregateException ex)
            {
                if (task.IsCanceled)
                {
                    Console.WriteLine($"Задача {task.Id} была отменена\n");
                }
            }
            finally
            {
                tokenSource.Dispose();
            }
        }
        private static void Task5()
        {
            Task<int> sumTask = new Task<int>(() => Sum(4, 5));
            // задача продолжения
            Task<int> subTask = sumTask.ContinueWith(t => Sub(4, 5));
            Task<int> mulTask = subTask.ContinueWith(t => Mul(4, 5));
            Task printTask1 = sumTask.ContinueWith(t => PrintResult(t.Result));
            Task printTask2 = subTask.ContinueWith(t => PrintResult(t.Result));
            Task printTask3 = mulTask.ContinueWith(t => PrintResult(t.Result));

            sumTask.Start();

            // ждем окончания второй задачи
            printTask3.Wait();

            int Sum(int a, int b) => a + b;
            int Sub(int a, int b) => a - b;
            int Mul(int a, int b) => a * b;
            void PrintResult(int sum) => Console.WriteLine($"Результат задачи: {sum}");
            //объект ожидания
            var awaiter = sumTask.GetAwaiter();
            awaiter.OnCompleted(() =>
            {
                int res = awaiter.GetResult();
                Console.WriteLine($"Результат задачи GetAwaiter(): {res}");
            });
        }
}
