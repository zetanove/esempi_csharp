using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap7_Inheritance
{
    public interface IFoo
    {
        void Bar();
    }

    public interface IWhatever
    {
        void Bar();
        void Method();
    }

    public class MyClass : IFoo, IWhatever
    {
        public void Bar() //standard implementation
        {

        }

        public void Method() //standard implementation
        {

        }

        void IFoo.Bar() //explicit implementation
        {
            Console.WriteLine("IFoo.Bar");
        }


        void IWhatever.Bar() //explicit implementation
        {
            Console.WriteLine("IWhatever.Bar");
        }

        void IWhatever.Method() //explicit implementation
        {
            Console.WriteLine("IWhatever.Method");
        }
    }

    
}
