using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap9_Generics_e_Collections
{
    public class Lista<T> 
    {
        private T[] elementi;

        public Lista(int numElementi)
        {
            elementi = new T[numElementi];
        }

        public void Metodo(T val)
        {
            if (val is string)
            {
                //string i = (string)val; errore
                string str = val as string;
                if (str != null)
                {
                    Console.WriteLine(str);
                }
            }
        }

        public void Metodo2(T val)
        {
            if (val is int)
            {
                //int i = (int)val; //errore
                int i = (int)(object)val;
                Console.WriteLine(i);
            }
        }


        public T this[int index]
        {
            get
            {
                return elementi[index];
            }
        }


    }
}
