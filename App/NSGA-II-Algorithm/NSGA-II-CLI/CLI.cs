using System;
using System.Collections.Generic;
using NSGA_II_Algorithm.implementations;
using NSGA_II_Algorithm.models;

namespace NSGA_II_CLI
{
    internal class CLI
    {
        private static List<Item> GetMockDataItems()
        {
            var list = new List<Item>
            {
                new Item("Lantisor de aur", 0.7, 500, 1),
                new Item("Unicorn", 100, 300, 2),
                new Item("Caldare", 2, 30, 30),
                new Item("Mar", 0.2, 3, 3),
                new Item("Sticla", 0.7, 4, 4),
                new Item("Telefon", 70, 500, 2.5),
                new Item("Banane", 0.2, 2, 3),
                new Item("Parfum", 0.4, 50, 4),
                new Item("Acumulator", 0.6, 250, 7),
                new Item("Televizor", 10, 800, 40),
                new Item("Lanterna", 0.2, 30, 2.2),
                new Item("Calculator", 10, 2400, 70),
                new Item("Portofel cu bani", 0.1, 300, 5),
                new Item("Elicopter RC", 0.5, 700, 20),
                new Item("MASA DE TENIS", 20, 640, 100),
                new Item("Biscuiti Oreo", 0.5, 5, 5)
            };
            return list;
        }

        private static List<Chromosome> GetMockDataChromosomes(int size, int nrGenes)
        {
            var list = new List<Chromosome>();
            for (var i = 0; i < size; ++i) list.Add(Chromosome.GenerateRandomChromosome(nrGenes));
            return list;
        }

        private static List<NonDominatedSortAtom> GetMockDataNDSAtom(List<Chromosome> list)
        {
            return NonDominatedSortAtom.MapFromChromosomes(list);
        }

        private static List<CrowdingDistanceAtom> GetMockDataCDAtom(List<Chromosome> list)
        {
            return CrowdingDistanceAtom.MapFromChromosomes(list);
        }

        private static void PrintTest()
        {
            Console.WriteLine("\n######################################\n");
            var items = GetMockDataItems();
            for (var index = 0; index < items.Count; index++) Console.WriteLine($"{index + 1} - {items[index]}\n");

            Console.WriteLine("\n######################################\n");
            var chromosomes = GetMockDataChromosomes(20, items.Count);

            for (var index = 0; index < chromosomes.Count; index++)
            {
                Console.WriteLine($"{index + 1} - {chromosomes[index]}");
                Console.WriteLine($"{chromosomes[index].GetInfo(items)}\n");
            }

            Console.WriteLine("\n######################################\n");
            var ndsAtoms = GetMockDataNDSAtom(chromosomes);
            for (var index = 0; index < ndsAtoms.Count; index++) Console.WriteLine($"{index + 1} - {ndsAtoms[index]}");

            Console.WriteLine("\n######################################\n");
            var cdAtoms = GetMockDataCDAtom(chromosomes);
            for (var index = 0; index < cdAtoms.Count; index++) Console.WriteLine($"{index + 1} - {cdAtoms[index]}");
        }


        private static void Main(string[] args)
        {
            //PrintTest();
            
            var items = GetMockDataItems();
            var nsgaAlgorithm = new NsgaAlgorithm(0.9, 0.02, items);

            nsgaAlgorithm.Process(10, 10, true);
            Console.WriteLine("Press Enter ...");
            Console.ReadLine();
        }
    }
}