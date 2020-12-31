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

        public List<List<Chromosome>> SortByFronts(List<Chromosome> chromosomes)
        {
            var fronts = _nonDominatedSort.Sort(NonDominatedSortAtom.MapFromChromosomes(chromosomes));
            return fronts.Select(NonDominatedSortAtom.MapToChromosomes).ToList();
        }

        public List<Chromosome> Process(int nrGenerations, int populationSize)
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
                Console.WriteLine($"\n############### GENERATION {currentGeneration+1}###########");

                //TournamentSelection of Parents
                var selectedPairParents = _geneticOperations.Selection(chromosomes);
                Console.WriteLine($"\nSelected Pair Parents size: {selectedPairParents.Count}");

                //Crossover
                var children = new List<Chromosome>();

                foreach (var selectedParents in selectedPairParents)
                {
                    children.Add(_geneticOperations.Crossover(selectedParents.Item1, selectedParents.Item1));
                }
                Console.WriteLine($"\nChildren size: {children.Count}");
                Chromosome.printList(children);

                //Mutation
                children = Chromosome.RemoveDuplicated(children.Select(child => _geneticOperations.Mutation(child)).ToList());
                Console.WriteLine($"\nAfter Mutation Children size: {children.Count}");
                Chromosome.printList(children);

                //New Population
                chromosomes.AddRange(children);
                //chromosomes = Chromosome.RemoveDuplicated(chromosomes).Take(Math.Min(populationSize, chromosomes.Count)).ToList();
                Console.WriteLine($"\nNew Population size: {chromosomes.Count}");

                //Non Dominated Sort
                Console.WriteLine($"\n############ NON DOMINATED SORT ###############");
                var fronts = _nonDominatedSort.Sort(NonDominatedSortAtom.MapFromChromosomes(chromosomes));

                for (int i = 0; i < fronts.Count; ++i)
                {
                    Console.WriteLine($"\r\nFront {i+1} front size {fronts[i].Count}");
                    Chromosome.printListPlus(NonDominatedSortAtom.MapToChromosomes(fronts[i]), _items);
                }

                var newPopulation = new List<Chromosome>();

                var currentFront = 0;
                while (currentFront < fronts.Count && newPopulation.Count + fronts[currentFront].Count <= populationSize)
                {
                    newPopulation.AddRange(NonDominatedSortAtom.MapToChromosomes(fronts[currentFront]));
                    currentFront++;
                }

                Console.WriteLine($"Front for crowding distance {currentFront}");
                Console.WriteLine($"Current new Population Size {newPopulation.Count}");

                //Crowding Distance Sort
                Console.WriteLine($"\n############ CROWDING DISTANCE SORT ###############");

                var selectedAtoms = _crowdingDistanceSort.Sort(
                    CrowdingDistanceAtom.MapFromChromosomes(
                        NonDominatedSortAtom.MapToChromosomes(fronts[currentFront])));
                Console.WriteLine($"Current Selected Atoms {selectedAtoms.Count}");

                newPopulation.AddRange(CrowdingDistanceAtom.MapToChromosomes(selectedAtoms.Take(populationSize - newPopulation.Count).ToList()));
                Chromosome.printListPlus(newPopulation, _items);

                chromosomes = newPopulation;
                chromosomes = Chromosome.RemoveDuplicated(chromosomes).Take(Math.Min(populationSize, chromosomes.Count)).ToList();

            }
            return chromosomes;
        }
    }
}
