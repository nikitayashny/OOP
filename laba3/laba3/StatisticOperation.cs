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
    }
}
