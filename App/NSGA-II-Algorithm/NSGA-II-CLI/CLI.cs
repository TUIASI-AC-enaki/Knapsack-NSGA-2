using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NSGA_II_Algorithm;
using NSGA_II_Algorithm.models;

namespace NSGA_II_CLI
{
    class CLI
    {

        static List<Item> GetMockDataItems()
        {
            var list = new List<Item>();
            list.Add(new Item("Caldare", 2, 30, 30));
            list.Add(new Item("Unicorn", 100, 300, 100));
            list.Add(new Item("Mar", 0.2, 3, 3));
            list.Add(new Item("Biscuiti Oreo", 0.5, 5, 5));
            list.Add(new Item("Sticla", 0.7, 4, 4));
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

        static void Main(string[] args)
        {
            Console.WriteLine("\n######################################\n");
            var items = GetMockDataItems();
            for (var index = 0; index < items.Count; index++)
            {
                Console.WriteLine($"{index+1} - {items[index]}\n");
            }

            Console.WriteLine("\n######################################\n");
            var chromosomes = GetMockDataChromosomes(20, items.Count);

            for (var index = 0; index < chromosomes.Count; index++)
            {
                Console.WriteLine($"{index+1} - {chromosomes[index]}");
                Console.WriteLine($"{chromosomes[index].GetInfo(items)}\n");
            }

            Console.WriteLine("Hello world!\n");
            Console.ReadLine();
        }
    }
}
