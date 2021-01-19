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

        /// <summary>
        /// Sort the list of chromosomes in fronts
        /// </summary>
        /// <param name="chromosomes">List of chromosomes</param>
        /// <returns>List of fronts</returns>
        public List<List<Chromosome>> SortByFronts(List<Chromosome> chromosomes)
        {
            var fronts = _nonDominatedSort.Sort(NonDominatedSortAtom.MapFromChromosomes(chromosomes));
            return fronts.Select(NonDominatedSortAtom.MapToChromosomes).ToList();
        }

        /// <summary>
        /// Generate a list of chromosomes.
        /// Repeat nrGenerations the follwing:
        /// - Select parents with tournament method
        /// - Crossover
        /// - Mutation
        /// - Append generate children to the current population
        /// - Non dominated Sort
        /// - Crowding Distance Sort for the last front to be inserted in order to complete the newPopulation to the last size
        /// </summary>
        /// <param name="nrGenerations">Number of generations for evolution</param>
        /// <param name="populationSize">Population Size of Chromosome</param>
        /// <param name="debug">Display Info Variable</param>
        /// <returns>A list of chromosomes</returns>
        public List<Chromosome> Process(int nrGenerations, int populationSize, bool debug=false)
        {
            var chromosomes = new List<Chromosome>();
            for (var i = 0; i < populationSize; i++)
            {
                chromosomes.Add(Chromosome.GenerateRandomChromosome(_items.Count));
            }

            if (populationSize > Math.Pow(2, _items.Count))
            {
                populationSize = (int) (Math.Pow(2, _items.Count) / 2);
            }

            //chromosomes = Chromosome.RemoveDuplicated(chromosomes).Take(Math.Min(populationSize, chromosomes.Count)).ToList();

            for (var currentGeneration = 0; currentGeneration < nrGenerations; ++currentGeneration)
            {
                for (int i = chromosomes.Count; i < populationSize; ++i)
                {
                    chromosomes.Add(Chromosome.GenerateRandomChromosome(_items.Count));
                }
                if (debug)
                    Console.WriteLine($"\n############### GENERATION {currentGeneration+1}###########");

                //TournamentSelection of Parents
                var selectedPairParents = _geneticOperations.Selection(chromosomes);
                if (debug)
                    Console.WriteLine($"\nSelected Pair Parents size: {selectedPairParents.Count}");

                //Crossover
                var children = new List<Chromosome>();

                foreach (var selectedParents in selectedPairParents)
                {
                    children.Add(_geneticOperations.Crossover(selectedParents.Item1, selectedParents.Item1));
                }

                if (debug)
                {
                    Console.WriteLine($"\nChildren size: {children.Count}");
                    Chromosome.PrintList(children);
                }

                //Mutation
                children = Chromosome.RemoveDuplicated(children.Select(child => _geneticOperations.Mutation(child)).ToList());
                if (debug)
                {
                    Console.WriteLine($"\nAfter Mutation Children size: {children.Count}");
                    Chromosome.PrintList(children);
                }

                //New Population
                chromosomes.AddRange(children);
                //chromosomes = Chromosome.RemoveDuplicated(chromosomes).Take(Math.Min(populationSize, chromosomes.Count)).ToList();
                if (debug)
                    Console.WriteLine($"\nNew Population size: {chromosomes.Count}");

                //Non Dominated Sort
                if (debug)
                    Console.WriteLine($"\n############ NON DOMINATED SORT ###############");
                var fronts = _nonDominatedSort.Sort(NonDominatedSortAtom.MapFromChromosomes(chromosomes));

                if (debug)
                    for (int i = 0; i < fronts.Count; ++i)
                    {
                        Console.WriteLine($"\r\nFront {i+1} front size {fronts[i].Count}");
                        Chromosome.PrintListPlus(NonDominatedSortAtom.MapToChromosomes(fronts[i]), _items);
                    }

                var newPopulation = new List<Chromosome>();

                var currentFront = 0;
                while (currentFront < fronts.Count && newPopulation.Count + fronts[currentFront].Count <= populationSize)
                {
                    newPopulation.AddRange(NonDominatedSortAtom.MapToChromosomes(fronts[currentFront]));
                    currentFront++;
                }

                if (debug)
                {
                    Console.WriteLine($"Front for crowding distance {currentFront}");
                    Console.WriteLine($"Current new Population Size {newPopulation.Count}");

                    //Crowding Distance Sort
                    Console.WriteLine($"\n############ CROWDING DISTANCE SORT ###############");
                }

                var selectedAtoms = _crowdingDistanceSort.Sort(
                    CrowdingDistanceAtom.MapFromChromosomes(
                        NonDominatedSortAtom.MapToChromosomes(fronts[currentFront])));
                if (debug)
                    Console.WriteLine($"Current Selected Atoms {selectedAtoms.Count}");

                newPopulation.AddRange(CrowdingDistanceAtom.MapToChromosomes(selectedAtoms.Take(populationSize - newPopulation.Count).ToList()));
                if (debug)
                    Chromosome.PrintListPlus(newPopulation, _items);

                chromosomes = newPopulation;
                chromosomes = Chromosome.RemoveDuplicated(chromosomes).Take(Math.Min(populationSize, chromosomes.Count)).ToList();

            }
            return chromosomes;
        }
    }
}
