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
                Console.WriteLine("Введите размерность матрицы: ");
                int nn = Convert.ToInt32(Console.ReadLine());
                string str;

                Matrix<int> mass1 = new Matrix<int>(nn);
                Matrix<int> mass2 = new Matrix<int>(nn);
                Matrix<int> mass3 = new Matrix<int>(nn);
                Matrix<int> mass4 = new Matrix<int>(nn);
                Matrix<int> mass5 = new Matrix<int>(nn);

                Console.WriteLine("ввод Матрица А: ");
                mass1.InputMat(1);
                Console.WriteLine("Ввод Матрица B: ");
                mass2.InputMat(2);

                Console.WriteLine();
                Console.WriteLine("Матрица А: ");
                mass1.OutputMat(1);
                Console.WriteLine();
                Console.WriteLine("Матрица В: ");
                mass2.OutputMat(2);
                Console.WriteLine();

                Console.WriteLine("Сложение матриц А и Б: ");
                mass3 = (mass1 + mass2);
                mass3.OutputMat(3);
                Console.WriteLine();

                Console.WriteLine("Удаление заданной строки:");
                mass4 = (mass1 - 1);
                mass4.OutputMat(4);
                Console.WriteLine();

                Console.WriteLine("Сравнение матриц:");
                str = (mass1 > mass2);
                Console.WriteLine(str);
                Console.WriteLine();

                Console.WriteLine("Копирование матрицы:");
                mass5 = (mass2 * 1);
                mass5.OutputMat(5);
                Console.WriteLine();

                mass5.DeleteMat(5);
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