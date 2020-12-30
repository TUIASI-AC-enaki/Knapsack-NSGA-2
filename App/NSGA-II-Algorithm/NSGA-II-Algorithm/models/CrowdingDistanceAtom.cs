using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSGA_II_Algorithm.models
{
    public class CrowdingDistanceAtom
    {
        private Chromosome _chromosome;
        private double _crowdingDistance;

        public CrowdingDistanceAtom(Chromosome chromosome)
        {
            _chromosome = chromosome;
            _crowdingDistance = 0;
        }

        public Chromosome Chromosome
        {
            get => _chromosome;
            set => _chromosome = value;
        }

        public double CrowdingDistance
        {
            get => _crowdingDistance;
            set => _crowdingDistance = value;
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append($"CrowdingDistanceAtom:\n");
            sb.Append($"\t{Chromosome}\n");
            sb.Append($"\tCrowding Distance: {_crowdingDistance}");
            return sb.ToString();
        }

        public static List<CrowdingDistanceAtom> MapFromChromosomes(List<Chromosome> list)
        {
            return list.Select(chromosome => new CrowdingDistanceAtom(chromosome)).ToList();
        }

        public static List<Chromosome> MapToChromosomes(List<CrowdingDistanceAtom> list)
        {
            return list.Select(crowd => crowd.Chromosome).ToList();
        }
    }
}
