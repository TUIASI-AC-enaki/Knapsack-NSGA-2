using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using NSGA_II_Algorithm;
using NSGA_II_Algorithm.implementations;
using NSGA_II_Algorithm.models;

namespace NSGA_II_CLI
{
    class CLI
    {

        static List<Item> GetMockDataItems()
        {
            var list = new List<Item>
            {
                new Item("Caldare", 2, 30, 30),
                new Item("Unicorn", 100, 300, 100),
                new Item("Mar", 0.2, 3, 3),
                new Item("Biscuiti Oreo", 0.5, 5, 5),
                new Item("Sticla", 0.7, 4, 4)
            };
            return list;
        }

        static List<Chromosome> GetMockDataChromosomes(int size, int nrGenes)
        {
            var list = new List<Chromosome>();
            for (var i = 0; i < size; ++i)
            {
                list.Add(Chromosome.GenerateRandomChromosome(nrGenes));
            }
            return list;
        }

        static List<NonDominatedSortAtom> GetMockDataNDSAtom(List<Chromosome> list)
        {
            return NonDominatedSortAtom.MapFromChromosomes(list);
        }

        static List<CrowdingDistanceAtom> GetMockDataCDAtom(List<Chromosome> list)
        {
            return CrowdingDistanceAtom.MapFromChromosomes(list);
        }

        static void PrintTest()
        {
            Console.WriteLine("\n######################################\n");
            var items = GetMockDataItems();
            for (var index = 0; index < items.Count; index++)
            {
                Console.WriteLine($"{index + 1} - {items[index]}\n");
            }

            Console.WriteLine("\n######################################\n");
            var chromosomes = GetMockDataChromosomes(20, items.Count);

            for (var index = 0; index < chromosomes.Count; index++)
            {
                Console.WriteLine($"{index + 1} - {chromosomes[index]}");
                Console.WriteLine($"{chromosomes[index].GetInfo(items)}\n");
            }

            Console.WriteLine("\n######################################\n");
            var ndsAtoms = GetMockDataNDSAtom(chromosomes);
            for (var index = 0; index < ndsAtoms.Count; index++)
            {
                Console.WriteLine($"{index + 1} - {ndsAtoms[index]}");
            }

            Console.WriteLine("\n######################################\n");
            var cdAtoms = GetMockDataCDAtom(chromosomes);
            for (var index = 0; index < cdAtoms.Count; index++)
            {
                Console.WriteLine($"{index + 1} - {cdAtoms[index]}");
            }
            Console.ReadLine();
        }


        static void Main(string[] args)
        {
            //PrintTest();
            var items = GetMockDataItems();
            var nsgaAlgorithm = new NsgaAlgorithm(0.9, 0.02, items);

            nsgaAlgorithm.Process(1, 20);
            Console.ReadLine();

        }
    }
}
