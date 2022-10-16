using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2
{
    partial class Partial
    {
        public override int GetHashCode()
        {
            int hash = 0;
            Random rand = new Random();
            for (int i = 0; i < name.Length; i++)
            {
                hash += name[i];
            }
            hash *= rand.Next(1000, 999999);
            return (int)Math.Abs(hash * name.Length);
        }
    }
}
