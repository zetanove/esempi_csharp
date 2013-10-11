using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    public class Smartphone
    {
        public class TelephoneNumber
        {
            public string Nome {get;set;}
            public int Number { get; set; }
        }

        private TelephoneNumber[] numeri;

        public TelephoneNumber this[int index]
        {
            get
            {
                return numeri[index];
            }
            set
            {
                numeri[index] = value;
            }
        }

        public TelephoneNumber this[string nome]
        {
            get
            {
                foreach (TelephoneNumber number in numeri)
                {
                    if (number.Nome == nome)
                        return number;
                }
                return null;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
