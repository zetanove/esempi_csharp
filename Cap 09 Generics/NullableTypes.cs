using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap9_Generics_e_Collections
{
    public class NullableTypes
    {
        public static void Test()
        {
            int? variabile = null;

            if (variabile != null)
            {
                variabile = 1;
            }

            int def = variabile.GetValueOrDefault();
            variabile = null;
            def=variabile.GetValueOrDefault(4);

            def = variabile ?? 4;


            int? x = 1;
            int? y = 2;
            int z = 3;

            int w= (int)x + z;

            int? somma = x + y; //
            Console.Write(somma);

            x = null;
            somma = x + y; //restituisce null
            Console.Write(somma);

            x = null;
            int? result = x * 2; //restituisce null
            Console.Write(result);

        }
    }
}
