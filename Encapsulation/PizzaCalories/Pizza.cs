using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaCalories
{
    public class Pizza
    {
        private string name;
        private List<Topping> topping;

        public Pizza(string name, Dough dough)
        {
            this.Name = name;
            this.Dough = dough;
            this.topping = new List<Topping>();
            AddTopping();
        }
        public string Name
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 1 || value.Length > 15)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }
                this.name = value;
            }
        }
        public Dough Dough { get; set; }
        public IReadOnlyCollection<Topping> Toppings { get { return this.topping.AsReadOnly(); } }
        public double Calories => PizzaCalories();

        public void AddTopping()
        {
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "END")
            {
                if (this.Toppings.Count > 10)
                {
                    throw new ArgumentException("Number of toppings should be in range [0..10].");
                }
                string[] token = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string type = token[1];
                double weigth = double.Parse(token[2]);
                Topping top = new Topping(type, weigth);
                this.topping.Add(top);
            }
        }

        public double PizzaCalories()
        {
            double calories = this.Dough.DoughCalories + this.topping.Sum(p => p.ToppingCalories);
            return calories;
        }

    }
}
