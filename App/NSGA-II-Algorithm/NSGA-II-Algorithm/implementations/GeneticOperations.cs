using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NSGA_II_Algorithm.interfaces;
using NSGA_II_Algorithm.models;

namespace NSGA_II_Algorithm.implementations
{
    class GeneticOperations: IGeneticOperations
    {
        public double _crossoverProbability;
        public double _mutationProbability;
        public double _selectionProbability;
        
        private Random rnd = new Random(new System.DateTime().Millisecond);

        public GeneticOperations(double crossoverProbability, double mutationProbability, double selectionProbability)
        {
            _crossoverProbability = crossoverProbability;
            _mutationProbability = mutationProbability;
            _selectionProbability = selectionProbability;
        }

        public Chromosome Crossover(Chromosome parent1, Chromosome parent2)
        {
            if (parent1.Size != parent2.Size)
                throw new Exception("Size of chromosome should be the same");

            var child = new Chromosome(parent1.Size);

            var sliceIndex = rnd.Next(parent1.Size);
            for (var index = 0; index < sliceIndex; ++index)
                child.Selected[index] = parent1.Selected[index];

            for (var index = sliceIndex; index < parent1.Size; ++index)
                child.Selected[index] = parent1.Selected[index];

            return child;
        }

        public Chromosome Mutation(Chromosome item)
        {
            for (var i = 0; i < item.Size; ++i)
            {
                if (rnd.NextDouble() >= _mutationProbability)
                {
                    item.Selected[i] = !item.Selected[i];
                }
            }
            return item;
        }

        public Chromosome Selection(List<Chromosome> items)
        {
            var idx1 = rnd.Next(0, items.Count);
            var idx2 = rnd.Next(0, items.Count);
            //TODO alegere dupa front, apoi dupa crowding daca front sunt egale

        }
    }
}
