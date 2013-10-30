using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CustomAttributes
{
    [Serializable]
    [Obsolete( "Classe non più supportata")]
    class MiaClasse
    {
        [Obsolete("Il metodo provoca errori", true)]
        public void Method()
        { }

        [Conditional("DEBUG")]
        public void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MiaClasse obj = new MiaClasse();
            //obj.Method();

            obj.ShowMessage("esecuzione in debug");

            var attributes = Assembly.GetExecutingAssembly().GetCustomAttributes();
            foreach (Attribute attr in attributes)
            {
                Console.WriteLine(attr.GetType().Name);
            }

            AssemblyTitleAttribute assemblyTitle = Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyTitleAttribute>();
            Console.WriteLine("AssemblyTitle: {0}", assemblyTitle.Title);

            attributes= typeof(MiaClasse).GetCustomAttributes();
            foreach (Attribute attr in attributes)
            {
                Console.WriteLine(attr.GetType().Name);
            }

            var members= typeof(MiaClasse).GetTypeInfo().DeclaredMembers;
            foreach (MemberInfo mi in members)
            {
                attributes = mi.GetCustomAttributes();
                if (attributes.Any())
                {
                    Console.WriteLine("{0} {1} attributes", mi.MemberType, mi.Name);
                    foreach (Attribute attr in attributes)
                    {
                        Console.WriteLine(attr.GetType().Name);
                    }
                }
            }

            Console.ReadLine();
        }
    }

}
