using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba7
{
    interface IMatrix<T>
    {
        void InputMat(T info);
        void OutputMat(T info);
        void DeleteMat(T info);
    }
    class Matrix<T> : IMatrix<T>
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

        public void InputMat(T info)  // Ввод матрицы с клавиатуры
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

        public void OutputMat(T info) // Вывод матрицы 
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

        public void DeleteMat(T info)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    mass[i,j] = 0;
                }
            }
        }

        public static Matrix<T> Sum(Matrix<T> a, Matrix<T> b)
        {
            Matrix<T> resMass = new Matrix<T>(a.N);
            for (int i = 0; i < a.N; i++)
            {
                for (int j = 0; j < b.N; j++)
                {
                    resMass[i, j] = a[i, j] + b[i, j];
                }
            }
            return resMass;
        }

        public static Matrix<T> operator +(Matrix<T> a, Matrix<T> b)     // Перегрузка сложения
        {
            return Sum(a, b);
        }

        public static Matrix<T> ToDelete(Matrix<T> a, int pos)
        {
            Matrix<T> resMass = new Matrix<T>(a.N);
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

        public static Matrix<T> operator -(Matrix<T> a, int pos)      // перегрузка удаления
        {
            return ToDelete(a, pos);
        }

        public static string Compare(Matrix<T> a, Matrix<T> b)
        {
            for (int i = 0; i < a.n; i++)
                for (int j = 0; j < a.n; j++)
                    if (a[i, j] != b[i, j])
                        return "Матрицы не равны";
            return "Матрицы равны";
        }

        public static string operator <(Matrix<T> a, Matrix<T> b)     // перегрузка сравнения
        {
            return Compare(a, b);
        }

        public static string operator >(Matrix<T> a, Matrix<T> b)
        {
            return Compare(a, b);
        }

        public static Matrix<T> Copy(Matrix<T> a)
        {
            Matrix<T> resMass = new Matrix<T>(a.N);
            for (int i = 0; i < a.N; i++)
            {
                for (int j = 0; j < a.N; j++)
                {
                    resMass[i, j] = a[i, j];
                }
            }
            return resMass;
        }

        public static Matrix<T> operator *(Matrix<T> a, int b)        // перегрузка копирования
        {
            return Copy(a);
        }



        Production Product = new Production(143, "ДОМОЧАЙ");      // вложенный объект
        class Production                                        // вложенные класс
        {
            public Production(int id, string nameOfOrganization)
            {
                _id = id;
                _nameOfOrganization = nameOfOrganization;
            }
            public int Id
            {
                get { return _id; }
                set { _id = value; }
            }
            public string NameOfOrganization
            {
                get { return _nameOfOrganization; }
                set { _nameOfOrganization = value; }
            }
            private int _id;
            private string _nameOfOrganization;
        }


        public class Developer
        {
            int _id;
            public int Id
            {
                get { return _id; }
                set { _id = value; }
            }
            string _nameOfDeveloper;

            public string NameOfDeveloper
            {
                get { return _nameOfDeveloper; }
                set { _nameOfDeveloper = value; }
            }
            string _otdel;

            public string OTdel
            {
                get { return _otdel; }
                set { _otdel = value; }
            }
            public Developer(int id, string name, string otdel)
            {
                _id = id;
                _nameOfDeveloper = name;
                _otdel = otdel;
            }
        }

        ~Matrix()                                               // Деструктор Matrix
        {
            Console.WriteLine("Очистка");
        }
    }
}
