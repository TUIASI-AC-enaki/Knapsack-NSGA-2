using System.Collections.Generic;
using NSGA_II_Algorithm.models;

namespace NSGA_Tests
{
    static class MockDataProvider
    {
        public static List<Item> getItems1()
        {
            var list = new List<Item>
            {
                new Item("Unicorn", 100, 300, 3),
                new Item("YoYo", 2, 40, 30),
                new Item("Monolit", 30, 50, 50),
                new Item("Guitar", 4, 70, 60),
            };
            return list;
        }

    }
}
