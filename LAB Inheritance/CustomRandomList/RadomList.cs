using System;
using System.Collections.Generic;
using System.Text;

namespace CustomRandomList
{
   public class RadomList : List<string>
    {

        private Random rand;

        public RadomList()
        {
           rand = new Random();
        }
        public string RemoveRandomElement()
        {
            int index = rand.Next(0, this.Count);
            string remove = this[index];
            this.RemoveAt(index);
            return remove;
        }
    }
}
