using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eccezioni
{
    class Program
    {
        public static int Divide(int x, int y)
        {
            return x / y;
        }

        static void Main(string[] args)
        {
            if (args.Length == 2)
            {
                int a = int.Parse(args[0]);
                int b = int.Parse(args[1]);
                if (b != 0)
                {
                    int risultato = Divide(a, b);
                    Console.WriteLine(risultato);
                }
                else Console.WriteLine("impossibile dividere per zero");
            }
            else Console.WriteLine("Inserisci due numeri interi");
        }
    }
}
