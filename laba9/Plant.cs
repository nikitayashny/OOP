using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba9
{
    class Plant
    {
        public string type;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public Plant(string type)
        {
            Type = type;
        }
        public override string ToString()
        {
            return Type;
        }
    }
}
