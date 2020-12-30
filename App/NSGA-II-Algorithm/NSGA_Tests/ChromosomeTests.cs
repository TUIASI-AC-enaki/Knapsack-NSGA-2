using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSGA_II_Algorithm.models;

namespace NSGA_Tests
{
    [TestClass]
    public class ChromosomeTests
    {
        [TestMethod]
        public void Dominate1()
        {
            var items = MockDataProvider.getItems1();

            var chromsome1 = new Chromosome(items.Count, new[] {false, true, false});
            var chromsome2 = new Chromosome(items.Count, new[] {false, false, true });
            
            Assert.AreEqual(1, chromsome1.Dominates(chromsome2, items));
            Assert.AreEqual(-1, chromsome2.Dominates(chromsome1, items));
            Assert.AreEqual(0, chromsome1.Dominates(chromsome1, items));
            Assert.AreEqual(0, chromsome2.Dominates(chromsome2, items));
        }
    }
}
