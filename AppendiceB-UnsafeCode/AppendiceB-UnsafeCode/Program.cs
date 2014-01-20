using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppendiceB_UnsafeCode
{
    class Program
    {
        static unsafe void Main(string[] args)
        {
            unsafe
            {
                int i = 123;

                int* pInt1=&i;
                int* pInt2;
                pInt2 = pInt1;

                Console.WriteLine("{0} {1}", *pInt1, *pInt2);

                Node node=new Node();
                Node* pn=&node;
                pn->Value = 1;

                Console.WriteLine(node.Value);
                (*pn).Value = 2;
                Console.WriteLine(node.Value);

                Fibonacci(10);
            }
        }


        public unsafe struct Node
        {
            public int Value;
            public Node* Left;
            public Node* Right;
        }

        public unsafe static void Fibonacci(int arraySize)
        {
            int* fib = stackalloc int[arraySize];
            int* p = fib;
            //La sequenza inizia con 1, 1.
            *p++ = *p++ = 1;
            for (int i = 2; i < arraySize; ++i, ++p)
            {
                // Somma i due precedenti
                *p = p[-1] + p[-2];
            }
            for (int i = 0; i < arraySize; ++i)
            {
                Console.WriteLine(fib[i]);
            }
        }

    }
}
