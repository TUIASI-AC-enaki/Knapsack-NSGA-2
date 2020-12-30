using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NSGA_II_Algorithm.models;

namespace NSGA_Tests
{
    static class MockDataProvider
    {
        public static List<Item> getItems1()
        {
            var list = new List<Item>
            {
                new Item("Caldare", 2, 30, 30),
                new Item("Unicorn", 100, 300, 100),
                new Item("Roaba", 150, 100, 120),
            };
            return list;
        }

    }
}
