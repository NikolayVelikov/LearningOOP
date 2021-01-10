using System;
using System.Linq;

namespace OOP___default
{
    class Program
    {
        static void Main(string[] args)
        {
            //Animal animal = new Animal("gOSHO", 15);
            //Dog dog = new Dog("Pesho",25,"Male");

            //Console.WriteLine(animal.Producesound());
            //Console.WriteLine(animal);

            //string value = 5.ToString();

            int a = 5;
            int b = a;
            b = 10;
            Console.WriteLine(a);
            Console.WriteLine(b);

            int[] array1 = new int[] { 1, 2 };
            int[] array2 = array1;
            for (int i = 0; i < array1.Length; i++)
            {
                array2[i] = array1[i];
            }
            array2[0] = 5;
            Console.WriteLine($"Array1 = {array1[0]}");
            Console.WriteLine($"Array2 = {array2[0]}");

        }
    }
}
