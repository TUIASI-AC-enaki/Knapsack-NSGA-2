using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSGA_II_Algorithm.interfaces
{
    interface ISort<T>
    {
        List<T> Sort(List<T> list);
    }
}
