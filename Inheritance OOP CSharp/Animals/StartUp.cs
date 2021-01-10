using System;
using System.Collections.Generic;

namespace Animals
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string errorMessage = "Invalid input!";
            string type = string.Empty;
            List<Animal> animals = new List<Animal>();
            while ((type = Console.ReadLine()) != "Beast!")
            {
                Animal monster = null;
                try
                {
                    if (String.IsNullOrWhiteSpace(type))
                    {
                        throw new ArgumentException(errorMessage);
                    }
                    string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    string name = input[0];
                    int age = int.Parse(input[1]);
                    switch (type)
                    {
                        case "Dog": monster = new Dog(name, age, input[2]); break;
                        case "Cat": monster = new Cat(name, age, input[2]); break;
                        case "Frog": monster = new Frog(name, age, input[2]); break;
                        case "Kitten": monster = new Kitten(name, age); break;
                        case "Tomcat": monster = new Tomcat(name, age); break;
                        default: throw new ArgumentException();
                    }
                }
                catch (Exception)
                {

                    Console.WriteLine(errorMessage);
                    continue;
                }
                animals.Add(monster);
            }

            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal);
            }
        }
    }
}
