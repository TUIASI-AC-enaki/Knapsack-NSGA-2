using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSGA_II_Algorithm.models
{
    public class NonDominatedSortAtom
    {
        private Chromosome _chromosome;
        private int _dominationCount;
        private List<NonDominatedSortAtom> _dominates;

        public NonDominatedSortAtom(Chromosome chromosome)
        {
            _chromosome = chromosome;
            _dominationCount = 0;
            _dominates = new List<NonDominatedSortAtom>();
        }

        public Chromosome Chromosome
        {
            get => _chromosome;
            set => _chromosome = value;
        }

        public int DominationCount
        {
            get => _dominationCount;
            set => _dominationCount = value;
        }

        public List<NonDominatedSortAtom> Dominates
        {
            get => _dominates;
            set => _dominates = value;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append($"NonDominatedSortAtom:\n");
            sb.Append($"\t{Chromosome}\n");
            sb.Append($"\tDominationCount: {_dominationCount}");
            return sb.ToString();
        }

        public static List<NonDominatedSortAtom> MapFromChromosomes(List<Chromosome> list)
        {
            return list.Select(chromosome => new NonDominatedSortAtom(chromosome)).ToList();
        }

        public static List<Chromosome> MapToChromosomes(List<NonDominatedSortAtom> list)
        {
            return list.Select(atom => atom.Chromosome).ToList();
        }
    }
}
