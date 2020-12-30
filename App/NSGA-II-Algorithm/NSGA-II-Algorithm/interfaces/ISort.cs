using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSGA_II_Algorithm.interfaces
{
    interface ISort<T, G>
    {
        List<G> Sort(List<T> list);
    }
}
