using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSGA_II_Algorithm.implementations;
using NSGA_II_Algorithm.models;

namespace NSGA_Tests
{
    [TestClass]
    public class CrowdingDistanceSortTests
    {
        [TestMethod]
        public void CrowdingSortTest1Edges()
        {
            var items = MockDataProvider.getItems1();
            var crowdingSort = new CrowdingDistanceSort(items);

            var chromosomeList = new List<Chromosome>()
            {
                new Chromosome(items.Count, new[] {false, true, false, false}),
                new Chromosome(items.Count, new[] {false, false, true, false}),
                new Chromosome(items.Count, new[] {false, false, false, true})
            };

            var crowdingList = crowdingSort.Sort(CrowdingDistanceAtom.MapFromChromosomes(chromosomeList));
            Assert.AreEqual(Double.PositiveInfinity, crowdingList[0].CrowdingDistance);
            Assert.AreEqual(Double.PositiveInfinity, crowdingList[1].CrowdingDistance);
        }

        [TestMethod]
        public void CrowdingSortTest1Middle()
        {
            var items = MockDataProvider.getItems1();
            var crowdingSort = new CrowdingDistanceSort(items);

            var chromosomeList = new List<Chromosome>()
            {
                new Chromosome(items.Count, new[] {false, true, false, false}),
                new Chromosome(items.Count, new[] {false, false, true, false}),
                new Chromosome(items.Count, new[] {false, false, false, true})
            };

            var crowdingList = crowdingSort.Sort(CrowdingDistanceAtom.MapFromChromosomes(chromosomeList));
            Assert.AreEqual(2, crowdingList[2].CrowdingDistance);
        }
    }
}
