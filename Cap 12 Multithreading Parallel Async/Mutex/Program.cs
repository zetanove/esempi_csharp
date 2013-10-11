using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MutexTest
{
    class Program
    {
        static void Main(string[] args)
        {
            bool createdNew;
            Mutex mutex = new Mutex(false, "MyMutex123", out createdNew);

            if (!createdNew)
            {
                Console.WriteLine("E' possibile eseguire solo un'istanza dell'applicazione");
            }

            if (mutex.WaitOne())
            {
                try
                {
                    //sezione critica
                }
                finally
                {
                    mutex.ReleaseMutex();
                }
            }
        }
    }
}
