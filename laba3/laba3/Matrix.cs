using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba3
{
    class Matrix
    {
        private int n;
        private int[,] mass;

        public Matrix() { } // конструктор матрицы
        public int N
        {
            get { return n; }
            set { if (value > 0) n = value; }
        }

        public Matrix(int n)    //  аксессоры для работы с полями вне класса Matrix
        {
            this.n = n;
            mass = new int[this.n, this.n];
        }
        public int this[int i, int j]
        {
            get
            {
                return mass[i, j];
            }
            set
            {
                mass[i, j] = value;
            }
        }

        public void InputMat()  // Ввод матрицы с клавиатуры
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine("Введите элемент матрицы {0}:{1}", i + 1, j + 1);
                    mass[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }

        // Вывод матрицы с клавиатуры
        public void OutputMat()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(mass[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        public static Matrix Sum(Matrix a, Matrix b)
        {
            Matrix resMass = new Matrix(a.N);
            for (int i = 0; i < a.N; i++)
            {
                for (int j = 0; j < b.N; j++)
                {
                    resMass[i, j] = a[i, j] + b[i, j];
                }
            }
            return resMass;
        }

        public static Matrix operator +(Matrix a, Matrix b)     // Перегрузка сложения
        {
            return Sum(a, b);
        }

        public static Matrix ToDelete(Matrix a, int pos)
        {
            Matrix resMass = new Matrix(a.N);
            for (int i = 0; i < a.N; i++)
            {
                if (i == (pos - 1))
                {
                    i += 1;
                }
                for (int j = 0; j < a.N; j++)
                {
                    resMass[i, j] = a[i, j];
                }
            }
            return resMass;
        }

        public static Matrix operator -(Matrix a, int pos)      // перегрузка удаления
        {
            return ToDelete(a, pos);
        }

        public static string Compare(Matrix a, Matrix b)
        {
            for (int i = 0; i < a.n; i++)
                for (int j = 0; j < a.n; j++)
                    if (a[i, j] != b[i, j])
                        return "Матрицы не равны";
            return "Матрицы равны";
        }

        public static string operator <(Matrix a, Matrix b)     // перегрузка операторов <>
        {
            return Compare(a, b);
        }

        public static string operator >(Matrix a, Matrix b)
        {
            return Compare(a, b);
        }

        ~Matrix()                                               // Деструктор Matrix
        {
            Console.WriteLine("Очистка");
        }

    }
}
