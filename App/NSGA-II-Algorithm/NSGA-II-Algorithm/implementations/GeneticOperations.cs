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
        private IReadOnlyList<Item> _items;

        public double _crossoverProbability;
        public double _mutationProbability;
        public double _selectionProbability;
        
        private Random rnd = new Random(new System.DateTime().Millisecond);

        public GeneticOperations(double crossoverProbability, double mutationProbability, double selectionProbability, IReadOnlyList<Item> items)
        {
            _crossoverProbability = crossoverProbability;
            _mutationProbability = mutationProbability;
            _selectionProbability = selectionProbability;
            _items = items;
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
            var clone = item.Clone();
            for (var i = 0; i < item.Size; ++i)
            {
                if (rnd.NextDouble() >= _mutationProbability)
                {
                    clone.Selected[i] = !clone.Selected[i];
                }
            }
            return clone;
        }


        public List<Chromosome> Selection(List<Chromosome> items, int sizeSelectedParents)
        {
            var parents = new List<Chromosome>();

            for (var i = 0; i < sizeSelectedParents; ++i)
            {
                var idx1 = rnd.Next(0, items.Count);
                var idx2 = rnd.Next(0, items.Count);

                var dominate = items[idx1].Dominates(items[idx2], _items);
                if (dominate == 1)
                {
                    parents.Add(items[idx1]);
                } else if (dominate == 0)
                {
                    parents.Add(items[idx2]);
                }
                else
                {
                    parents.Add(rnd.NextDouble() < 0.5 ? items[idx1]: items[idx2]);
                }
            }
            return parents;
        }
    }
}
