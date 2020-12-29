using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace NSGA_II_Algorithm.models
{
    public class Chromosome
    {
        public Chromosome(int size)
        {
            Size = size;
            Selected = new bool[size];
        }

        public static Chromosome generateRandomChromosome(int size)
        {
            var rnd = new Random();
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
            double price = 0;
            for(int i = 0; i < items.Count; ++i)
            {
                if (Selected[i])
                {
                    price += items[i].Price;
                }
            }
            return price;
        }

        public double GetFitnessByTime(IReadOnlyList<Item> items)
        {
            double time = 0;
            for (int i = 0; i < items.Count; ++i)
            {
                if (Selected[i])
                {
                    time += items[i].TimeRequired;
                }
            }
            return time;
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
            else if ((cCost >= thisCost && cTime <= thisTime) && (cCost > thisCost || cTime < thisTime))
            {
                return -1;
            }
            return 0;
        }
    }
}
