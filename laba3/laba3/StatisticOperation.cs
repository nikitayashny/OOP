using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba3
{
    static class StatisticOperation
    {
        public static int Sum(Matrix a)
        {
            int sum = 0;
            for (int i = 0; i < a.N; i++)
            {
                for (int j = 0; j < a.N; j++)
                {
                    sum += a[i, j];
                }
            }
            return sum;
        }
        public static int Diff(Matrix a)
        {
            int max = a[0, 0];
            int min = a[0, 0];
            for (int i = 0; i < a.N; i++)
            {
                for (int j = 0; j < a.N; j++)
                {
                    if (max < a[i, j])
                        max = a[i, j];
                    if (min > a[i, j])
                        min = a[i, j];
                }
            }
            return max - min;
        }
        public static int Count(Matrix a)
        {
            int count = 0;
            for (int i = 0; i < a.N; i++)
            {
                for (int j = 0; j < a.N; j++)
                {
                    count += 1;
                }
            }
            return count;
        }

        public static string FormatText(this string str)
        {
            return char.ToUpper(str[0]) + str.Substring(1).ToLower();
        }

        public static int MainSum(this Matrix a)
        {
            int mainsum = 0;
            for (int i = 0; i < a.N; i++)
            {
                for (int j = 0; j < a.N; j++)
                {
                    if (i == j)
                    {
                        mainsum += a[i, j];
                    }
                }
            }
            return mainsum;
        }
    }
}
