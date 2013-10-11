using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classi
{
    class Customer
    {
        public string name;
    }

    class Point
    {
        int x;
        int y;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Customer drJekyll = new Customer();
            Customer mrHide;
            mrHide=drJekyll;
            if (mrHide == drJekyll)
                Console.WriteLine("mrHyde e drJekyll sono la stessa persona");

            drJekyll.name = "Henry";
            Console.WriteLine("{0} Jekyll", drJekyll.name);
            Console.WriteLine("{0} Hide", mrHide.name);

            mrHide = null;
            Console.WriteLine("{0} Jekyll", drJekyll.name);
            // la prossima scatena eccezione null reference
            //Console.WriteLine("{0} Hide", mrHide.name);

            Point p = new Point();
        }
    }
}
