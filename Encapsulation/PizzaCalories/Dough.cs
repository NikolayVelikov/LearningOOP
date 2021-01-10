using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Dough
    {
        private const double defaultCalories = 2;
        private string typeFlour;
        private double flourCalories;
        private string technique;
        private double technieuqCalories;
        private double weigth;

        public Dough(string flour, string technique, double weigth)
        {
            this.TypeFlour = flour;
            this.BakingTechnique = technique;
            this.Weigth = weigth;
        }
        public string TypeFlour
        {
            get { return this.typeFlour; }
            private set
            {
                switch (value.ToLower())
                {
                    case "white": this.typeFlour = value; this.flourCalories = 1.5; break;
                    case "wholegrain": this.typeFlour = value; this.flourCalories = 1.0; break;
                    default: throw new ArgumentException("Invalid type of dough.");
                }
            }
        }
        public string BakingTechnique
        {
            get { return this.technique; }
            private set
            {
                switch (value.ToLower())
                {
                    case "crispy": this.technique = value; this.technieuqCalories = 0.9; break;
                    case "chewy": this.technique = value; this.technieuqCalories = 1.1; break;
                    case "homemade": this.technique = value; this.technieuqCalories = 1.0; break;
                    default: throw new ArgumentException("Invalid type of dough.");
                }
            }
        }
        public double Weigth
        {
            get { return this.weigth; }
            private set
            {
                if (value < 1 || value > 200)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }
                this.weigth = value;
            }
        }
        public double DoughCalories => Calories();

        private double Calories()
        {
            double calories = (defaultCalories * this.Weigth) * this.technieuqCalories * this.flourCalories;

            return calories;
        }
    }
}
