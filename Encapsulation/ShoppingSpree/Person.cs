using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree
{
    public class Person
    {
        private const string NAME_ERROR = "Name cannot be empty";
        private const string MONEY_ERROR = "Money cannot be negative";

        private string name;
        private double money;
        private List<string> boughtProducts;

        public Person(string name, double money)
        {
            this.Name = name;
            this.Money = money;
            this.boughtProducts = new List<string>();
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
        public double Money
        {
            get { return this.money; }
           private set
            {
                if (value < 0)
                {
                    throw new ArgumentException(MONEY_ERROR);
                }
                this.money = value;
            }
        }
        public IReadOnlyCollection<string> Products { get { return this.boughtProducts.AsReadOnly(); } }
        public void Bought(Product product)
        {
            if (product.Cost > this.Money)
            {
                Console.WriteLine($"{this.Name} can't afford {product.Name}");
            }
            else
            {
                this.Money -= product.Cost;
                boughtProducts.Add(product.Name);
                Console.WriteLine($"{this.Name} bought {product.Name}");
            }           
        }
    }
}
