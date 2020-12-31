using System;
using System.Text;

namespace NSGA_II_Algorithm.models
{
    /// <summary>
    /// Item representing the objects that can be taken.
    /// Item contains:
    /// - name
    /// - weight
    /// - price
    /// - time required t be taken
    /// </summary>
    public class Item
    {
        private readonly String _name;
        private readonly double _weight;
        private readonly double _price;
        private readonly double _timeRequired;

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
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append($"{Name}\n");
            sb.Append($"\tWeight: {Weight}\n");
            sb.Append($"\tPrice: {Price}\n");
            sb.Append($"\tTimeRequired: {TimeRequired}\n");
            return sb.ToString();
        }
    }
}
