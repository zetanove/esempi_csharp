using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeOfTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            Type t1 = i.GetType();
            Type t2 = typeof(int);
            Console.WriteLine(t1.FullName);
            Console.WriteLine(t2.FullName);

            Console.WriteLine(typeof(decimal).IsPrimitive);
        }
    }
}
