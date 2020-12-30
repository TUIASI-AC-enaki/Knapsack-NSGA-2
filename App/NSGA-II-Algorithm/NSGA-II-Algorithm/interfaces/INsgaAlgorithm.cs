using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NSGA_II_Algorithm.models;

namespace NSGA_II_Algorithm.interfaces
{
    public interface INsgaAlgorithm
    {
        List<Chromosome> Process(int nrGenerations, int populationSize);
    }
}
