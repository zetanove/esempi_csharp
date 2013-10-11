using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap9_Generics_e_Collections
{
    struct Point<T> where T:struct
    {
        public T x;
        public T y;
    }
}
