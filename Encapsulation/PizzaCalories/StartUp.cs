using System;

namespace PizzaCalories
{
    class StartUp
    {
        static void Main(string[] args)
        {
            try
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (input.Length < 2)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }
                string pizzaName = input[1];
                
                //Dough dough = Flour();                    
                Pizza pizza = new Pizza(pizzaName, Dough());

                Console.WriteLine($"{pizza.Name} - {pizza.Calories:f2} Calories.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static Dough Dough()
        {
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string flour = input[1];
            string technique = input[2];
            double weigth = double.Parse(input[3]);
            Dough dough = new Dough(flour, technique, weigth);

            return dough;
        }
    }
}
