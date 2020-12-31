using System.Collections.Generic;

namespace NSGA_II_Algorithm.interfaces
{
    interface ISort<T, G>
    {
        List<G> Sort(List<T> list);
    }
}
