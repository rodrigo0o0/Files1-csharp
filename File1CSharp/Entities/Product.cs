using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File1CSharp.Entities
{
    internal class Product
    {
        public string Name { get; set; }
        public double Value { get; set; }
        public int Amount { get; set; }

        public Product(string name, double value, int amount)
        {
            Name = name;
            Value = value;
            Amount = amount;
        }
        public double CalculateTotalValue()
        {
            return Value * Amount;
        }
    }
}
