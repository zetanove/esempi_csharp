using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LanciareEccezioni
{
    class Program
    {
        public static void Throw()
        {
            try
            {
                Console.WriteLine("metodo Throw");
                int b = 0;
                int a = 1 / b;
            }
            catch
            {
                throw;
            }
        }

        public static void ThrowEx()
        {
            try
            {
                Console.WriteLine("metodo ThrowEx");
                int b = 0;
                int a = 1 / b;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public static void WebEx()
        {
            try
            {
                Console.WriteLine("metodo WebEx");
                WebClient client = new WebClient();
                client.DownloadFile("http://www.sitononesistente.org/nomedir/nomefile.txt", "C:\\temp\\test.txt");
            }
            catch (WebException ex)
            {
                if (ex.Status == WebExceptionStatus.NameResolutionFailure)
                    Console.WriteLine("file non esistente");
                else throw;
            }
        }

        static void Main(string[] args)
        {
            try
            {
                Throw();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }


            try
            {
                ThrowEx();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            try
            {
                WebEx();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
