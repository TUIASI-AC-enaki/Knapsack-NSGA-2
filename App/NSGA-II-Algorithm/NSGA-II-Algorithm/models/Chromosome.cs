using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace NSGA_II_Algorithm.models
{
    public class Chromosome
    {
        static readonly Random rnd = new Random();

        public Chromosome(int size)
        {
            Size = size;
            Selected = new bool[size];
        }

        public Chromosome(int size, bool[] selected)
        {
            Size = size;
            Selected = (bool[]) selected.Clone();
        }

        public static Chromosome GenerateRandomChromosome(int size)
        {
            var temp = new Chromosome(size);
            for (var i = 0; i < size; ++i)
            {
                temp.Selected[i] = rnd.NextDouble() >= 0.5;
            }
            return temp;
        }

        public int Size { get; }

        public bool[] Selected { get; }

        public double GetFitnessByCost(IReadOnlyList<Item> items)
        {
            return items.Where((t, i) => Selected[i]).Sum(t => t.Price);
        }

        public double GetFitnessByTime(IReadOnlyList<Item> items)
        {
            return items.Where((item, index) => Selected[index]).Sum(item => item.TimeRequired);
        }

        public double GetFitnessByWeight(IReadOnlyList<Item> items)
        {
            return items.Where((t, i) => Selected[i]).Sum(t => t.Weight);
        }

        public int Dominates(Chromosome c, IReadOnlyList<Item> items)
        {
            var thisCost = this.GetFitnessByCost(items);
            var thisTime = this.GetFitnessByTime(items);
            var cCost = c.GetFitnessByCost(items);
            var cTime = c.GetFitnessByTime(items);
            if ((thisCost >= cCost && thisTime <= cTime) && (thisCost > cCost || thisTime < cTime))
            {
                return 1;
            }

            if ((cCost >= thisCost && cTime <= thisTime) && (cCost > thisCost || cTime < thisTime))
            {
                return -1;
            }
            return 0;
        }

        public Chromosome Clone()
        {
            return new Chromosome(this.Size, this.Selected);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append($"Chromosome: ({Size}, [");
            sb.Append(string.Join(" ", Selected.Select(value => value ? 1 : 0)));
            sb.Append("])");
            return sb.ToString();
        }

        public string ToStringPlus(IReadOnlyList<Item> items)
        {
            var sb = new StringBuilder();
            sb.Append($"{this}\n");
            sb.Append($"{this.GetInfo(items)}");
            return sb.ToString();
        }

        public bool IsEqual(Chromosome obj)
        {
            if (Size != obj.Size)
                return false;
            for (var i = 0; i < obj.Size; ++i)
            {
                if (Selected[i] != obj.Selected[i])
                    return false;
            }

            return true;
        }

        public string GetInfo(IReadOnlyList<Item> items)
        {
            var sb = new StringBuilder();
            sb.Append($"\tWeight: {GetFitnessByWeight(items)}");
            sb.Append($"\n\tCost: {GetFitnessByCost(items)}");
            sb.Append($"\n\tTime Required: {GetFitnessByTime(items)}");
            return sb.ToString();
        }

        public static void printList(IReadOnlyList<Chromosome> chromosomes)
        {
            Console.WriteLine("##### CHROMOSOMES LIST ######");
            foreach (var chromosome in chromosomes)
            {
                Console.WriteLine(chromosome);
            }
        }

        public static void printListPlus(IReadOnlyList<Chromosome> chromosomes, IReadOnlyList<Item> items)
        {
            Console.WriteLine("##### CHROMOSOMES LIST PLUS ######");
            foreach (var chromosome in chromosomes)
            {
                Console.WriteLine(chromosome.ToStringPlus(items));
            }
        }

        public static List<Chromosome> RemoveDuplicated(List<Chromosome> chromosomes)
        {
            var filteredList = new List<Chromosome>();

            foreach (var chromosome in chromosomes)
            {
                if (filteredList.FindIndex(item => item.IsEqual(chromosome)) == -1)
                {
                    filteredList.Add(chromosome);
                }
            }
            return filteredList;
        }
    }
}
