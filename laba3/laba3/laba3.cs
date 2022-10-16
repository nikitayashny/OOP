using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba3
{
    class Programm
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность матрицы: ");
            int nn = Convert.ToInt32(Console.ReadLine());
            // Инициализация
            Matrix mass1 = new Matrix(nn);
            Matrix mass2 = new Matrix(nn);
            Matrix mass3 = new Matrix(nn);

            Console.WriteLine("ввод Матрица А: ");
            mass1.InputMat();
            Console.WriteLine("Ввод Матрица B: ");
            mass2.InputMat();

            Console.WriteLine("Матрица А: ");
            mass1.OutputMat();
            Console.WriteLine();
            Console.WriteLine("Матрица В: ");
            Console.WriteLine();
            mass2.OutputMat();

            Console.WriteLine("Сложение матриц А и Б: ");
            mass3 = (mass1 + mass2);
            mass3.OutputMat();


            Console.ReadKey();
        }
    }
}