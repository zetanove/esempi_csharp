using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametriDaPrompt
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length >= 2)
            {
                Console.WriteLine(args[0]);
                Console.WriteLine(args[1]);
            }
        }
    }
}
