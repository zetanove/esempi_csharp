using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericPromotions
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal decimal1=1m;
            double double1=1.2d;
            long long1 = 122L;
            ulong ulong1 = 12UL;
            short sh1 = 2;
            sbyte sb1 = 3;
            
            int i = 10;
            var res1=decimal1+i;
            Console.WriteLine(res1.GetType().FullName);
            var res2 = ulong1 + double1;


        }
    }
}
