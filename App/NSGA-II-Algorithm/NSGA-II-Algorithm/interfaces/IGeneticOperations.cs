using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NSGA_II_Algorithm.models;

namespace NSGA_II_Algorithm.interfaces
{
    public interface IGeneticOperations
    {
        Chromosome Crossover(Chromosome parent1, Chromosome parent2);
        Chromosome Mutation(Chromosome item);
        Chromosome TournamentSelection(List<Chromosome> chromosomes);
        List<Tuple<Chromosome, Chromosome>> Selection(List<Chromosome> chromosomes);
    }
}