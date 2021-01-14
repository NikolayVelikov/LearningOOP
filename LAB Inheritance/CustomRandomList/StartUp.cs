using System;

namespace CustomRandomList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            RadomList list = new RadomList();
            list.Add("gosho");
            list.Add("petar");
            list.Add("ivan");
            
            Console.WriteLine(list.RemoveRandomElement());
        }
    }
}
