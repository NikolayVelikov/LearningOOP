using System;
using System.Collections.Generic;

namespace Dummy1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] list1 = new int[1] { 1 };
            Console.WriteLine(string.Join(", ",list1));
            int[] list2 = list1;
            //int[] list2 = new int[](list1);
            list2[0] = 17;
            Console.WriteLine(string.Join(", ", list1));
            Console.WriteLine(string.Join(", ", list2));
        }
    }
}
