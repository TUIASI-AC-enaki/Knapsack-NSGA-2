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
            var chromosome1 = new Chromosome(items.Count, new[] {true, false, false, false});
            var chromosome2 = new Chromosome(items.Count, new[] {false, false, true, false });
            
            Assert.AreEqual(1, chromosome1.Dominates(chromosome2, items));
        }

        [TestMethod]
        public void Dominate2()
        {
            var items = MockDataProvider.getItems1();
            var chromosome1 = new Chromosome(items.Count, new[] { true, false, false, false });
            var chromosome2 = new Chromosome(items.Count, new[] { false, false, true, false });

            Assert.AreEqual(-1, chromosome2.Dominates(chromosome1, items));
        }

        [TestMethod]
        public void Dominate3()
        {
            var items = MockDataProvider.getItems1();
            var chromosome1 = new Chromosome(items.Count, new[] { false, true, false, false });

            Assert.AreEqual(0, chromosome1.Dominates(chromosome1, items));
        }

        [TestMethod]
        public void Dominate4()
        {
            var items = MockDataProvider.getItems1();
            var chromosome2 = new Chromosome(items.Count, new[] { false, false, true, false });

            Assert.AreEqual(0, chromosome2.Dominates(chromosome2, items));
        }

        [TestMethod]
        public void IsChromosomeEqual1()
        {
            var chromosome1 = new Chromosome(4, new[] { false, false, true, true });
            var chromosome2 = new Chromosome(4, new[] { false, false, true, true });

            Assert.AreEqual(true, chromosome1.IsEqual(chromosome2));
        }

        [TestMethod]
        public void IsChromosomeEqual2()
        {
            var chromosome1 = new Chromosome(4, new[] { false, false, true, true });
            var chromosome2 = new Chromosome(5, new[] { false, false, true, true, false });

            Assert.AreEqual(false, chromosome1.IsEqual(chromosome2));
        }

        [TestMethod]
        public void IsChromosomeEqual3()
        {
            var chromosome1 = new Chromosome(4, new[] { true, false, true, true });
            var chromosome2 = new Chromosome(4, new[] { false, false, true, true });

            Assert.AreEqual(false, chromosome1.IsEqual(chromosome2));
        }
    }
}
