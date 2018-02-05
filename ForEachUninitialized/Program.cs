using System;

namespace ForEachUninitialized
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] listOfStrings;
            Console.WriteLine("Starting loop");
            foreach (var item in listOfStrings)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Finished loop");
            Console.ReadLine();
        }
    }
}
