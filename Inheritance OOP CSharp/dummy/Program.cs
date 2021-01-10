using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_06.STAR_Animals
{
    interface IProduceSound
    {
        string ProduceSound();
    }

    abstract class Animal
    {
        private string name;
        private int age;
        private string gender;

        public Animal(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        protected virtual string Gender
        {
            get { return gender; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid input!");
                }
                gender = value;
            }
        }

        protected int Age
        {
            get { return age; }
            set
            {
                if (string.IsNullOrWhiteSpace(value.ToString()) || value < 0)
                {
                    throw new ArgumentException("Invalid input!");
                }
                age = value;
            }
        }

        protected virtual string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid input!");
                }
                name = value;
            }
        }

        public virtual string GetResult()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append($"{this.Name} {this.Age} {this.Gender}{Environment.NewLine}");
            return stringBuilder.ToString();
        }

    }

    class Dog : Animal, IProduceSound
    {
        public Dog(string name, int age, string gender) : base(name, age, gender)
        {
            base.Name = name;
        }

        public string ProduceSound()
        {
            return "BauBau";
        }

        public override string GetResult()
        {
            return base.GetResult() + ProduceSound();
        }
    }

    class Frog : Animal, IProduceSound
    {
        public Frog(string name, int age, string gender) : base(name, age, gender)
        {
            base.Name = name;
        }

        public string ProduceSound()
        {
            return "Frogggg";
        }

        public override string GetResult()
        {
            return base.GetResult() + ProduceSound();
        }
    }

    class Cat : Animal, IProduceSound
    {
        public Cat(string name, int age, string gender) : base(name, age, gender)
        {
        }

        public string ProduceSound()
        {
            return "MiauMiau";
        }
        public override string GetResult()
        {
            return base.GetResult() + ProduceSound();
        }
    }

    class Kitten : Animal, IProduceSound
    {
        public Kitten(string name, int age, string gender) : base(name, age, gender)
        {
        }

        protected override string Gender
        {
            set
            {
                if (value != "Female")
                {
                    throw new ArgumentException("Invalid input!");

                }
                base.Gender = value;
            }
        }

        public string ProduceSound()
        {
            return "Miau";
        }

        public override string GetResult()
        {
            return base.GetResult() + ProduceSound();
        }
    }

    class Tomcat : Animal, IProduceSound
    {
        public Tomcat(string name, int age, string gender) : base(name, age, gender)
        {
        }

        protected override string Gender
        {
            set
            {
                if (value != "Male")
                {
                    throw new ArgumentException("Invalid input!");
                }
                base.Gender = value;
            }
        }


        public string ProduceSound()
        {
            return "Give me one million b***h";
        }

        public override string GetResult()
        {
            return base.GetResult() + ProduceSound();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().Trim();

            while (input != "Beast!")
            {
                try
                {
                    string[] dataDog = Console.ReadLine().Split(new char[] 
                    { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                    string name = dataDog[0];
                    int age;
                    if (!int.TryParse(dataDog[1], out age))
                    {
                        throw new ArgumentException("Invalid input!");
                    }

                    string gender = dataDog[2];


                    switch (input)
                    {
                        case "Dog":
                            Dog dog = new Dog(name, age, gender);
                            Console.WriteLine("Dog");
                            Console.WriteLine(dog.GetResult());
                            break;
                        case "Cat":
                            Cat cat = new Cat(name, age, gender);
                            Console.WriteLine("Cat");
                            Console.WriteLine(cat.GetResult());
                            break;
                        case "Frog":
                            Frog frog = new Frog(name, age, gender);
                            Console.WriteLine("Frog");
                            Console.WriteLine(frog.GetResult());
                            break;
                        case "Kitten":
                            Kitten kitten = new Kitten(name, age, gender);
                            Console.WriteLine("Kitten");
                            Console.WriteLine(kitten.GetResult());
                            break;
                        case "Tomcat":
                            Tomcat tomcat = new Tomcat(name, age, gender);
                            Console.WriteLine("Tomcat");
                            Console.WriteLine(tomcat.GetResult());
                            break;
                        default:
                            throw new ArgumentException("Invalid input!");
                    }
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input!");
                }
                input = Console.ReadLine().Trim();
            }
        }
    }
}