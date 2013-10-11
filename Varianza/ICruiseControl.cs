using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Varianza
{
    public interface ICruiseControl<in T>
    {
        void SetSpeed(T obj, double speed);
    }
}
