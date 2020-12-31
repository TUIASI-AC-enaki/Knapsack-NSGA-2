using System;
using System.Collections.Generic;
using NSGA_II_Algorithm.interfaces;
using NSGA_II_Algorithm.models;

namespace NSGA_II_Algorithm.implementations
{
    /// <summary>
    /// Class for genetic operations like:
    /// - selection
    /// - mutation
    /// - crossover
    /// - tournament selection
    /// </summary>
    class GeneticOperations: IGeneticOperations
    {
        private IReadOnlyList<Item> _items;

        public double _crossoverProbability;
        public double _mutationProbability;

        private Random rnd = new Random(new System.DateTime().Millisecond);

        public GeneticOperations(double crossoverProbability, double mutationProbability, IReadOnlyList<Item> items)
        {
            _crossoverProbability = crossoverProbability;
            _mutationProbability = mutationProbability;
            _items = items;
        }

        /// <summary>
        /// Select a slice index between 0..parents.genes.size and do the crossover between them
        /// </summary>
        /// <param name="parent1">Parent one chromosome</param>
        /// <param name="parent2">Parent one chromosome</param>
        /// <returns>New cross-over-ed chromosome</returns>
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

        /// <summary>
        /// Iterate through each gene of the chromosome and mutates it.
        /// </summary>
        /// <param name="item">Chromosome to be mutated</param>
        /// <returns>A mutated chromosome with the specific probability for each gene</returns>
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

        /// <summary>
        /// This function Select a chromosome using the tournament method
        /// </summary>
        /// <param name="chromosomes">List of chromosomes</param>
        /// <returns>A chromosome selected using tournament method</returns>
        public Chromosome TournamentSelection(List<Chromosome> chromosomes)
        {
            var idx1 = rnd.Next(0, chromosomes.Count);
            var idx2 = rnd.Next(0, chromosomes.Count);

            var dominate = chromosomes[idx1].Dominates(chromosomes[idx2], _items);
            switch (dominate)
            {
            case 1:
                return chromosomes[idx1];
            case -1:
                return chromosomes[idx2];
            default:
                return rnd.NextDouble() < 0.5 ? chromosomes[idx1]: chromosomes[idx2];
            }
        }

        /// <summary>
        /// This functions return a list of pair of parents of the same length as the input list using tournament method
        /// </summary>
        /// <param name="chromosomes">List of chromosomes</param>
        /// <returns>A list of pairs of selected parents using the tournament method</returns>
        public List<Tuple<Chromosome, Chromosome>> Selection(List<Chromosome> chromosomes)
        {
            var result = new List<Tuple<Chromosome, Chromosome>>();

            for (var i = 0; i < chromosomes.Count; ++i)
            {
                result.Add(Tuple.Create(TournamentSelection(chromosomes), TournamentSelection(chromosomes)));
            }
            return result;
        }
    }
}
