using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Topping
    {
        private const double defaultCalories = 2;
        private double additionalCalories;
        private double weigth;
        private string type;

        public Topping(string type, double weigth)
        {
            this.Type = type;
            this.Weigth = weigth;
        }

        public string Type
        {
            get { return this.type; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }

                switch (value.ToLower())
                {
                    case "meat": this.additionalCalories = 1.2; this.type = value; break;
                    case "veggies": this.additionalCalories = 0.8; this.type = value; break;
                    case "cheese": this.additionalCalories = 1.1; this.type = value; break;
                    case "sauce": this.additionalCalories = 0.9; this.type = value; break;
                    default:
                        throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                };
            }
        }
        public double Weigth
        {
            get { return this.weigth; }
            private set
            {
                if (value < 1 || value > 50)
                {
                    throw new ArgumentException($"{this.Type} weight should be in the range [1..50].");
                }
                this.weigth = value;
            }
        }

        public double ToppingCalories => Calories();

        private double Calories()
        {
            double calories = (defaultCalories * this.Weigth) *this.additionalCalories;

            return calories;
        }
    }
}
