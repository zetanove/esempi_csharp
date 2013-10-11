using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IstruzioneThrow
{
    class Program
    {
        static void Main(string[] args)
        {

            if (args.Length == 0)
            {
                throw new ArgumentNullException();
            }

            Console.Write("{0} argomenti", args.Length); // se l'eccezione viene lanciata non si arriverà mai a questa linea
        }
    }
}
