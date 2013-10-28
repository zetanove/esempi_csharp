using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Cap_14_Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Type t = typeof(string);
            
            string str = "abc";
            Type t2 = str.GetType();
            Console.WriteLine(t2.Name);
            Console.WriteLine(t2.Namespace);
            Console.WriteLine(t2.FullName);
            Console.WriteLine(t2.AssemblyQualifiedName);
            Console.WriteLine(t2.BaseType.FullName);
            
            TypeInfo ti= typeof(string).GetTypeInfo();
            Console.WriteLine(ti.Name);
            Console.WriteLine(ti.Namespace);
            Console.WriteLine(ti.FullName);
            Console.WriteLine(ti.AssemblyQualifiedName);
            Console.WriteLine(ti.BaseType.FullName);


            Type listGeneric= typeof(List<>);
            Console.WriteLine(listGeneric.FullName);
            Type listGenericInt = typeof(List<int>);
            Console.WriteLine(listGenericInt.FullName);

            Type arrayType = typeof(int[]);
            Console.WriteLine(arrayType.FullName);

            int[] arrayInt = new int[] { 1, 2, 3 };
            arrayInt.GetType();
            Console.WriteLine( arrayInt.GetType().FullName);


            
        }
    }
}
