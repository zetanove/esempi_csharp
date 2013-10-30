using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyReflection
{
    class Test
    {
        public Test(string name)
        {
            Name = name;
        }

        public Test()
        {
            Name = "untitled";
        }

        public string Name { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Assembly assm = Assembly.GetExecutingAssembly();
            assm = Assembly.GetAssembly(typeof(string));
            Console.WriteLine(assm.FullName);

            assm= typeof(string).Assembly;
            Console.WriteLine(assm.FullName);

            Type[] types=assm.GetTypes();

            Assembly mscorlib = typeof(int).Assembly;
            var enums = from type in mscorlib.DefinedTypes
                        where type.IsEnum
                        select type.FullName;
            enums.ToList().ForEach(Console.WriteLine);

            Type t = typeof(Test);
            Test test=(Test)Activator.CreateInstance(t, "name");

            Test test2 = Activator.CreateInstance<Test>();

        }
    }
}
