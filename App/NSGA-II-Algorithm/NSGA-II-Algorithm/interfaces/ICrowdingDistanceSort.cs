using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NSGA_II_Algorithm.models;

namespace NSGA_II_Algorithm.interfaces
{
    interface ICrowdingDistanceSort: ISort<CrowdingDistanceAtom, CrowdingDistanceAtom>
    {
    }
}
