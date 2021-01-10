using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public abstract class Animal
    {
        private const string ERROR_MESSAGE_FOR_OUTPU = "Invalid input!";

        private string name;
        private int age;
        private string gender;

        public Animal(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }
        public string Name
        {
            get { return this.name; }
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ERROR_MESSAGE_FOR_OUTPU);
                }
                this.name = value;
            }
        }
        public int Age
        {
            get { return this.age; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException(ERROR_MESSAGE_FOR_OUTPU);
                }
                this.age = value;
            }
        }
        public string Gender
        {
            get { return this.gender; }
            private set
            {
                if (value != "Female" && value != "Male")
                {
                    throw new ArgumentException(ERROR_MESSAGE_FOR_OUTPU);
                }
                this.gender = value;
            }
        }

        public abstract string ProduceSound();

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine($"{this.GetType().Name}").AppendLine($"{this.Name} {this.Age} {this.Gender}").AppendLine($"{ProduceSound()}");

            return output.ToString().TrimEnd();
        }
    }
}
