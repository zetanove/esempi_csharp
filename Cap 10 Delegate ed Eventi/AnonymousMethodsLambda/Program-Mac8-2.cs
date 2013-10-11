using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousMethodsLambda
{
    class Program
    {
        delegate bool CheckIntDelegate(int i);
        static void Main(string[] args)
        {
            List<int> lista=new List<int>(new int[] {1,2,3,4,5,6,7,8});
            List<int> numeripari=lista.FindAll(delegate(int i){
                return i%2==0;
            });
            numeripari.ForEach(Console.WriteLine);

            //lambda
            CheckIntDelegate del = (x => x % 2 == 0);
            var pari = del(234);

            Predicate<int> pred= (x => x % 2 == 0);
            bool b=pred(234521);

            var dispari = lista.FindLast(i => i % 2 != 0);
            
            Func<int,int, double> mediaFunc= (x,y) => (x+y)/2.0;
            double average=mediaFunc(3,7);

            Action<string,string> upperAction = (s1,s2) => {
                string s=s1+" "+s2;
                Console.WriteLine(s.ToUpper());
            };
            upperAction("Hello", "World");
        }
    }
}
