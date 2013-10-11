using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap9_Generics_e_Collections
{
    class Program
    {
        static void Main()
        {
            Point<int> pi = new Point<int>() { x = 1, y=2 };

            Lista<string> ls = new Lista<string>(1);
            ls.Metodo("test");

            new Lista<int>(0).Metodo2(123);


            NullableTypes.Test();
        }
    }
}
