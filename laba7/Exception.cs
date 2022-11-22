using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba7
{
    class DeleteNotFounded : Exception
    {
        public DeleteNotFounded(string message) : base(message) { }
    }

}
