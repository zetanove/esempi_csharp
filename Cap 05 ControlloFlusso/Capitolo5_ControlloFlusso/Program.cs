using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitolo5_ControlloFlusso
{
    class Program
    {
        public static bool NumeroPari(int x)
        {
            Console.WriteLine("Verifico se {0} è pari", x);
            return x % 2 == 0;
        }

        static void Main(string[] args)
        {
            int a= 2;
            int b = 3;
            int c = 4;

            //operatore & bitwise, esegue tutti e tre i metodi
            Console.WriteLine("verifica con &");
            if (NumeroPari(a) & NumeroPari(b) & NumeroPari(c))
            {
                Console.WriteLine("Tutti pari");
            }
            Console.WriteLine("Non sono tutti pari");

            //operatore &&, non esegue la verifica di c, perchè ha trovato b dispari
            Console.WriteLine("verifica con &&");
            if (NumeroPari(a) && NumeroPari(b) && NumeroPari(c))
            {
                Console.WriteLine("Tutti pari");
            }
            Console.WriteLine("Non sono tutti pari");
        }
    }
}
