using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Varianza
{
    interface IBuilder<out T>
    {
        T Build();
    }
}
