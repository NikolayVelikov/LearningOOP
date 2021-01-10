using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree
{
    public class Product
    {
        private const string NAME_ERROR = "Name cannot be empty";
        private const string MONEY_ERROR = "Money cannot be negative";

        private string name;
        private double cost;

        public Product(string name, double cost)
        {
            this.Name = name;
            this.Cost = cost;
        }
        public string Name
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(NAME_ERROR);
                }
                this.name = value;
            }
        }
        public double Cost
        {
            get { return this.cost; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(MONEY_ERROR);
                }
                this.cost = value;
            }
        }
    }
}
