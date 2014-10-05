using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitolo3
{
    class Program
    {
        static void Main(string[] args)
        {
            byte min = Byte.MinValue;
            byte max = Byte.MaxValue;
            Console.WriteLine("Byte, min: {0} max: {1}", min, max);

            //tipi anonimi
            var cliente=new {Nome="mario", Cognome="rossi", Età=50};
            //cliente.Nome = "pippo"; //errore Read Only
            Console.WriteLine("{0} {1}, anni {2}", cliente.Nome, cliente.Cognome, cliente.Età);
            Console.ReadLine();
        }
    }
}
