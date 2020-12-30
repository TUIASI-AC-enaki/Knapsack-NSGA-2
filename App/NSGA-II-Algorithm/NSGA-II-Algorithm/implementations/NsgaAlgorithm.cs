using System;
using System.Collections.Generic;
using System.Linq;
using NSGA_II_Algorithm.interfaces;
using NSGA_II_Algorithm.models;

namespace NSGA_II_Algorithm.implementations
{
    public class NsgaAlgorithm: INsgaAlgorithm
    {
        private IGeneticOperations _geneticOperations;
        private ICrowdingDistanceSort _crowdingDistanceSort;
        private INonDominatedSort _nonDominatedSort;
        private IReadOnlyList<Item> _items;

        public NsgaAlgorithm(double crossoverProbability, double mutationProbability, IReadOnlyList<Item> items)
        {
            _items = items;
            _geneticOperations = new GeneticOperations(crossoverProbability, mutationProbability, items);
            _crowdingDistanceSort = new CrowdingDistanceSort(items);
            _nonDominatedSort = new NonDominatedSort(items);
        }

        public List<Chromosome> Process(int nrGenerations, int populationSize)
        {
            var chromosomes = new List<Chromosome>();
            for (var i = 0; i < populationSize; i++)
            {
                chromosomes.Add(Chromosome.GenerateRandomChromosome(_items.Count));
            }

            for (var currentGeneration = 0; currentGeneration < nrGenerations; ++currentGeneration)
            {
                Console.WriteLine($"\n############### GENERATION {currentGeneration+1}###########");

                //Selection of Parents
                var selectedParents = _geneticOperations.Selection(chromosomes, chromosomes.Count / 2);
                Console.WriteLine($"\nSelected Parents size: {selectedParents.Count}");

                //Crossover
                var children = new List<Chromosome>();

                foreach (var mother in selectedParents)
                {
                    foreach (var father in selectedParents)
                    {
                        if (!mother.IsEqual(father))
                        {
                            children.Add(_geneticOperations.Crossover(mother, father));
                        }
                    }
                }
                Console.WriteLine($"\nChildren size: {children.Count}");
                Chromosome.printList(children);

                //Mutation
                children = Chromosome.RemoveDuplicated(children.Select(child => _geneticOperations.Mutation(child)).ToList());
                Console.WriteLine($"\nAfter Mutation Children size: {children.Count}");
                Chromosome.printList(children);
            }
            return new List<Chromosome>();

        }
    }
}
