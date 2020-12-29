using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSGA_II_Algorithm
{
    public class Item
    {
        private String _name;
        private double _weight;
        private double _price;
        private double _timeRequired;

        public Item(string name, double weight, double price, double timeRequired)
        {
            _name = name;
            _weight = weight;
            _price = price;
            _timeRequired = timeRequired;
        }

        public string Name => _name;

        public double Weight => _weight;

        public double Price => _price;

        public double TimeRequired => _timeRequired;
    }
}
