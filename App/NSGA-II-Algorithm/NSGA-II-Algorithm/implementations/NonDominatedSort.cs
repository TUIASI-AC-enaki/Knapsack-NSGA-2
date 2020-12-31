using System.Collections.Generic;
using NSGA_II_Algorithm.interfaces;
using NSGA_II_Algorithm.models;

namespace NSGA_II_Algorithm.implementations
{
    public class NonDominatedSort: INonDominatedSort
    {
        private IReadOnlyList<Item> _items;

        public NonDominatedSort(IReadOnlyList<Item> items)
        {
            _items = items;
        }

        /// <summary>
        /// Sort the atom list to fronts
        /// </summary>
        /// <param name="list">List nonDominatedSortAtom</param>
        /// <returns>Sorted List of fronts</returns>
        public List<List<NonDominatedSortAtom>> Sort(List<NonDominatedSortAtom> list)
        {
            var frontList = new List<List<NonDominatedSortAtom>>();

            // update the domination count and dominates list
            for (var i = 0; i < list.Count-1; ++i)
            {
                for (var j = i+1; j < list.Count; ++j)
                {
                    var dominateResult = list[i].Chromosome.Dominates(list[j].Chromosome, _items);
                    switch (dominateResult)
                    {
                        case 1:
                            list[j].DominationCount++;
                            list[i].Dominates.Add(list[j]);
                            break;
                        case -1:
                            list[i].DominationCount++;
                            list[j].Dominates.Add(list[i]);
                            break;
                        default:
                            break;
                    }
                }
            }

            // creating the fronts according to domination count and dominates list
            var running = true;
            while (running)
            {
                var currentFront = new List<NonDominatedSortAtom>();
                running = false;
                var dominatedList = new List<NonDominatedSortAtom>();
                for (var index = 0; index < list.Count; ++index)
                {
                    if (list[index].DominationCount == 0)
                    {
                        running = true;
                        list[index].DominationCount = -1;
                        currentFront.Add(list[index]);

                        foreach (var dominated in list[index].Dominates)
                        {
                            dominatedList.Add(dominated);
                        }
                    }
                }
                foreach (var dominated in dominatedList)
                {
                    dominated.DominationCount--;
                }

                if (currentFront.Count > 0)
                {
                    frontList.Add(currentFront);
                }
            }

            return frontList;
        }
    }

}
