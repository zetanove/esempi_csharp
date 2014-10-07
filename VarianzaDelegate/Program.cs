using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarianzaDelegate
{
    class Program
    {
        public delegate T MioDelegate<T, U>(U val);

        public delegate T CreationDelegate<out T>();

        public delegate int ConvertToIntDelegate<in T>(T obj);


        static int MioMetodo(string val)
        {
            return Convert.ToInt32(val);
        }

        public static string CreateString() { return ""; }
        public static object CreateObject() { return 1; }


        public static int ConvertString(string str)
        {
            
            return int.Parse(str);
        }

        public static int ConvertObject(object obj)
        {
            return Convert.ToInt32(obj);
        }



        static void Main(object[] args)
        {
            MioDelegate<int, string> del = MioMetodo;
            int i = del.Invoke("1");

            //covarianza
            CreationDelegate<string> delStr = CreateString;
            CreationDelegate<object> delObj = delStr;

            ConvertToIntDelegate<object> delConvObj = ConvertObject;
            ConvertToIntDelegate<string> delConvStr = delConvObj;
            delConvStr.Invoke("123");
        }
    }
}
