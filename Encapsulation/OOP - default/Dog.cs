namespace OOP___default
{
    public class Dog : Animal
    {
        public Dog(string name, int age, string gender) : base(name, age)
        {
            this.Gender = gender;
        }

        public string Gender { get; private set; }

        public override string Producesound()
        {
            return "Baubau";
        }
    }
}
