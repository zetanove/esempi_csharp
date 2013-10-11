using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int? i = null;

            if (i is int)
            {
                Console.WriteLine(i);
            }


            object j = 1;
            if (j is int)
            {
                Console.WriteLine("j is int");
            }

            int z = (int)j;
            if (z is int)
            {
            }

        }
    }
}
