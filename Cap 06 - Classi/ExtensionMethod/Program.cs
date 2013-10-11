using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{

    public static class StringExtensions
    {
        /// <summary>
        /// Verifica se la string contiene un numero double
        /// </summary>
        /// <param name="str">stringa da verificare</param>
        /// <returns>true se la stringa rappresenta un double</returns>
        public static bool IsNumeric(this string str)
        {
            double d;
            return double.TryParse(str, out d);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            string str = "123.45";
            bool isnumeric = str.IsNumeric();
            
        }
    }
}
