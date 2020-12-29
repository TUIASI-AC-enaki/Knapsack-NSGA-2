using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSGA_II_Algorithm.models
{
    class CrowdingDistanceAtom
    {
        private Chromosome _chromosome;
        private double _crowdingDistance;

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
    }
}
