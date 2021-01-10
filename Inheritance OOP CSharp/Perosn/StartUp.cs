using System;

namespace Person
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());


            Child child = new Child(name, age);

            Console.WriteLine(child);
            name = Console.ReadLine();
            age = int.Parse(Console.ReadLine());
            Child child1 = new Child(name, age);
            Console.WriteLine(child1);
        }
    }
}
