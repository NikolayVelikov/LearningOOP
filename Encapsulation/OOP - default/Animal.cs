namespace OOP___default
{
    public class Animal : IAnimal
    {
        public Animal(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name { get; private set; }

        public int Age { get; private set; }

        public virtual string Producesound()
        {
            return "I am Animal";
        }

        
        public override string ToString()
        {
            return $"Name: {this.Name}, Age {this.Age}";
        }
    }
}
