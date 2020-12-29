using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NSGA_II_Algorithm.interfaces;
using NSGA_II_Algorithm.models;

namespace NSGA_II_Algorithm.implementations
{
    class NonDominatedSort: INonDominatedSort
    {
        private IReadOnlyList<Item> _items;

        public NonDominatedSort(IReadOnlyList<Item> items)
        {
            _items = items;
        }

        public List<List<NonDominatedSortAtom>> Sort(List<NonDominatedSortAtom> list)
        {
            var frontList = new List<List<NonDominatedSortAtom>>();

            for (var i = 0; i < list.Count; ++i)
            {
                for (var j = i + 1; j < list.Count; ++j)
                {
                    var dominateResult = list[i].Chromosome.Dominates(list[j].Chromosome, _items);
                    switch (dominateResult)
                    {
                        case 1:
                            list[j].DominationCount++;
                            list[j].Dominates.Add(list[i]);
                            break;
                        case -1:
                            list[i].DominationCount++;
                            list[i].Dominates.Add(list[j]);
                            break;
                        default:
                            break;
                    }
                }
            }

            while (list.Count > 0)
            {
                var currentFront = new List<NonDominatedSortAtom>();
                for (var index = list.Count-1; index >= 0; ++index)
                {
                    if (list[index].DominationCount == 0)
                    {
                        currentFront.Add(list[index]);

                        for (var index2 = list.Count - 1; index2 >= 0; ++index2)
                        {
                            if (index2 == index) continue;
                            if (list[index2].Dominates.Remove(list[index]))
                            {
                                list[index2].DominationCount--;
                            }
                        }
                        list.RemoveAt(index);
                    }
                }
                frontList.Add(currentFront);
            }

            return frontList;
        }
    }

}
