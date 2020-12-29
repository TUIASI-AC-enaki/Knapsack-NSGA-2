using System;
using System.Collections.Generic;
using System.Linq;
using MoreLinq;
using NSGA_II_Algorithm.interfaces;
using NSGA_II_Algorithm.models;

namespace NSGA_II_Algorithm.implementations
{
    class CrowdingDistanceSort: ICrowdingDistanceSort
    {
        private IReadOnlyList<Item> _items;

        public CrowdingDistanceSort(IReadOnlyList<Item> items)
        {
            _items = items;
        }


        public List<CrowdingDistanceAtom> Sort(List<CrowdingDistanceAtom> list)
        {
            var maxByCost = list.MaxBy(atom => atom.Chromosome.GetFitnessByCost(_items)).ToList();
            var minByCost = list.MinBy(atom => atom.Chromosome.GetFitnessByCost(_items)).ToList();
            // cei cu max ByCost, le setam distantele pe infinit, asigurandu-ne ca sunt transmisi mai departe
            foreach (var atom in maxByCost)
            {
                atom.CrowdingDistance = double.PositiveInfinity;
            }

            var maxByTime = list.MaxBy(atom => atom.Chromosome.GetFitnessByTime(_items));
            var minByTime = list.MinBy(atom => atom.Chromosome.GetFitnessByTime(_items));
            // cei cu min ByTime, le setam distantele pe infinit, asigurandu-ne ca sunt transmisi mai departe
            foreach (var atom in minByTime)
            {
                atom.CrowdingDistance = double.PositiveInfinity;
            }

            var timeDifference = maxByTime.First().Chromosome.GetFitnessByTime(_items) -
                                 minByTime.First().Chromosome.GetFitnessByTime(_items);
            var costDifference = maxByTime.First().Chromosome.GetFitnessByCost(_items) -
                                 minByTime.First().Chromosome.GetFitnessByCost(_items);

            //deoarece sunt pe acelasi front nu conteaza daca sortam dupa Cost sau dupa Time
            var sortedAtomsByFitness = list.OrderBy(atom => atom.Chromosome.GetFitnessByCost(_items)).ToList();

            for (var i = 1; i < sortedAtomsByFitness.Count - 1; ++i)
            {
                sortedAtomsByFitness[i].CrowdingDistance =
                    (sortedAtomsByFitness[i + 1].Chromosome.GetFitnessByCost(_items) -
                    sortedAtomsByFitness[i - 1].Chromosome.GetFitnessByCost(_items))/costDifference;
                sortedAtomsByFitness[i].CrowdingDistance +=
                    sortedAtomsByFitness[i + 1].Chromosome.GetFitnessByTime(_items) -
                    sortedAtomsByFitness[i - 1].Chromosome.GetFitnessByTime(_items) / timeDifference;
            }

            return sortedAtomsByFitness.OrderByDescending(atom => atom.CrowdingDistance).ToList();
        }
    }
}
