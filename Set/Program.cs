using System;

namespace Set
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Set<int> set1 = new Set<int>();
            Set<int> set2 = new Set<int>();

            //set1.Add(set2);

            var sum = Set<int>.Union(set1, set2);

            
        }
    }
}
