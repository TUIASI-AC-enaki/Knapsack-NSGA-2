using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSGA_II_Algorithm.implementations;
using NSGA_II_Algorithm.models;

namespace NSGA_Tests
{
    [TestClass]
    public class NonDominatingSortTests
    {
        [TestMethod]
        public void NonDominatingSortTest1FirstFront()
        {
            var items = MockDataProvider.getItems1();
            var nonDominatingSort = new NonDominatedSort(items);

            var chromosomeList = new List<Chromosome>()
            {
                new Chromosome(items.Count, new[] {true, false, false, false}),
                new Chromosome(items.Count, new[] {false, false, true, false}),
                new Chromosome(items.Count, new[] {false, false, false, true})
            };

            var nonDominatingCrowdList = nonDominatingSort.Sort(NonDominatedSortAtom.MapFromChromosomes(chromosomeList));
            Assert.AreEqual(1, nonDominatingCrowdList[0].Count);
        }

        [TestMethod]
        public void NonDominatingSortTest1SecondFront()
        {
            var items = MockDataProvider.getItems1();
            var nonDominatingSort = new NonDominatedSort(items);

            var chromosomeList = new List<Chromosome>()
            {
                new Chromosome(items.Count, new[] {true, false, false, false}),
                new Chromosome(items.Count, new[] {false, false, true, false}),
                new Chromosome(items.Count, new[] {false, false, false, true})
            };

            var nonDominatingCrowdList = nonDominatingSort.Sort(NonDominatedSortAtom.MapFromChromosomes(chromosomeList));
            Assert.AreEqual(2, nonDominatingCrowdList[1].Count);
        }

        [TestMethod]
        public void NonDominatingSortTest2FirstFront()
        {
            var items = MockDataProvider.getItems1();
            var nonDominatingSort = new NonDominatedSort(items);

            var chromosomeList = new List<Chromosome>()
            {
                new Chromosome(items.Count, new[] {true, false, false, false}),
                new Chromosome(items.Count, new[] {true, false, true, false}),
                new Chromosome(items.Count, new[] {true, true, false, true})
            };

            var nonDominatingCrowdList = nonDominatingSort.Sort(NonDominatedSortAtom.MapFromChromosomes(chromosomeList));
            Assert.AreEqual(3, nonDominatingCrowdList[0].Count);
        }
    }
}
