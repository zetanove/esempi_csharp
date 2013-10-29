using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Xml;
using Cap_14_Reflection.Test;

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

            
            Console.WriteLine("Generics");
            Type listGeneric= typeof(List<>);
            Console.WriteLine(listGeneric.FullName);
            Type listGenericInt = typeof(List<int>);
            Console.WriteLine(listGenericInt.FullName);            

            List<string> lstr = new List<string>();
            var tinfo=lstr.GetType().GetTypeInfo();
            Console.WriteLine(tinfo.Name);

            Dictionary<int, string> dict = new Dictionary<int, string>();
            TypeInfo tiDict = dict.GetType().GetTypeInfo();
            Console.WriteLine(tiDict.FullName);
            Console.WriteLine(typeof(Dictionary<,>).GetTypeInfo().FullName);

            Console.WriteLine("Array");

            Type arrayType = typeof(int[]);            
            Console.WriteLine(arrayType.FullName); //System.Int32[]
            
            string[,] matrice = new string[3, 3];
            Console.WriteLine(matrice.GetType().FullName); //System.String[,]

            Type tabInteri= typeof(int).MakeArrayType(2);
            Console.WriteLine(tabInteri.FullName);

            Type listInteri = typeof(List<>).MakeGenericType(typeof(int));
            Console.WriteLine(listInteri.FullName);


            //ricava tipi per nome

            Type ts = Type.GetType("System.String");
            Console.WriteLine(ts.AssemblyQualifiedName);

            Type tx1= typeof(XmlDocument);
            Console.WriteLine(tx1.AssemblyQualifiedName);
            Type tx = Type.GetType("System.Xml.XmlDocument, System.Xml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089");

            string fullname = Assembly.GetExecutingAssembly().FullName;

            //nested types

            Type[] nestedTypes= typeof(Container).GetNestedTypes();
            foreach (Type nt in nestedTypes)
            {
                Console.WriteLine(nt.FullName);
            }

            Console.WriteLine("int type ");
            Type tipoInt=typeof(int);
            Console.WriteLine(tipoInt.IsAbstract);
            Console.WriteLine(tipoInt.IsArray);
            Console.WriteLine(tipoInt.IsClass);
            Console.WriteLine(tipoInt.IsEnum);
            Console.WriteLine(tipoInt.IsInterface);
            Console.WriteLine(tipoInt.IsNested);
            Console.WriteLine(tipoInt.IsNotPublic);
            Console.WriteLine(tipoInt.IsPointer);
            Console.WriteLine(tipoInt.IsPrimitive);
            Console.WriteLine(tipoInt.IsPublic);
            Console.WriteLine(tipoInt.IsSealed);
            Console.WriteLine(tipoInt.IsValueType);

            Console.WriteLine("Generic type ");
            Console.WriteLine("Dictionary<int, string>");
            Type tgen = typeof(Dictionary<int, string>);
            Console.WriteLine(tgen.IsGenericType);
            Console.WriteLine(tgen.IsGenericTypeDefinition);
            Console.WriteLine(tgen.ContainsGenericParameters);

            Console.WriteLine("Dictionary<,>");
            tgen = typeof(Dictionary<, >);
            Console.WriteLine(tgen.IsGenericType);
            Console.WriteLine(tgen.IsGenericTypeDefinition);
            Console.WriteLine(tgen.ContainsGenericParameters);

            Console.WriteLine("string methods");
            ts = typeof(String);
            MethodInfo[] methods = ts.GetMethods();
            foreach (MethodInfo mi in methods)
            {
                Console.WriteLine("{0} {1}", mi.ReturnType.Name, mi.Name);
            }
            
            Console.ReadLine();
            

        }
    }

    namespace Test
    {
        class Container
        {
            public class Nested
            {
                Nested() { }
            }
        }
    }
}
