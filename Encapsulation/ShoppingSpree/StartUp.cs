using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            try
            {
                string input = Console.ReadLine();
                string[] personsInformation = input.Split(';', StringSplitOptions.RemoveEmptyEntries);
                List<Person> people = new List<Person>();
                for (int i = 0; i < personsInformation.Length; i++)
                {
                    string[] individualInformation = personsInformation[i].Split('=', StringSplitOptions.RemoveEmptyEntries);
                    string name = individualInformation[0];
                    double money = double.Parse(individualInformation[1]);
                    Person person = new Person(name, money);
                    people.Add(person);
                }

                input = Console.ReadLine();
                string[] productInformation = input.Split(';', StringSplitOptions.RemoveEmptyEntries);
                List<Product> products = new List<Product>();
                for (int i = 0; i < productInformation.Length; i++)
                {
                    string[] individualInformation = productInformation[i].Split('=', StringSplitOptions.RemoveEmptyEntries);
                    string name = individualInformation[0];
                    double cost = double.Parse(individualInformation[1]);
                    Product product = new Product(name, cost);
                    products.Add(product);
                }

                while ((input = Console.ReadLine()) != "END")
                {
                    string[] whatToBuy = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    string namePerson = whatToBuy[0];
                    string nameProduct = whatToBuy[1];

                    if (products.Count == 0)
                    {
                        break;
                    }
                    Product currentProcut = products.First(p => p.Name == nameProduct);
                    if (people.Count == 0)
                    {
                        break;
                    }
                    Person currnetPerson = people.First(p => p.Name == namePerson);

                    currnetPerson.Bought(currentProcut);
                }

                foreach (Person person in people)
                {
                    if (person.Products.Count == 0)
                    {
                        Console.WriteLine($"{person.Name} - Nothing bought");
                        continue;
                    }
                    Console.Write($"{person.Name} - ");
                    Console.WriteLine(string.Join(", ", person.Products));
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

        }

    }
}
