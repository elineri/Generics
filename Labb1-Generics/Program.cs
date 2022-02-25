using System;

namespace Labb1_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create object of collection
            LådaCollection LådList = new LådaCollection();

            // Adding 5 new Låda objects to the collection
            LådList.Add(new Låda(10, 10, 10));
            LådList.Add(new Låda(20, 10, 30));
            LådList.Add(new Låda(30, 15, 10));
            LådList.Add(new Låda(25, 20, 20));
            LådList.Add(new Låda(30, 30, 30));

            // Test to add object with the same dimensions
            LådList.Add(new Låda(10, 10, 10));

            // Display method to loop through all objects in the collection
            Display(LådList);

            // Remove an object
            Console.WriteLine("\nTar bort objekt med dimensionerna 10, 10, 10");
            LådList.Remove(new Låda(10, 10, 10));
            Display(LådList);

            //***** Testing the Contains method with different dimensions
            // Låda lådaCheck = new Låda( 15, 15, 15 );
            Låda lådaCheck = new Låda(25, 20, 20);

            Console.WriteLine("\nCollection innehåller ett objekt med Höjd {0}, Bredd {1}, Längd {2} = {3}",
            lådaCheck.höjd, lådaCheck.bredd, lådaCheck.längd, LådList.Contains(lådaCheck));

            Låda lådaCheck2 = new Låda(15, 15, 15);
            
            Console.WriteLine("\nCollection innehåller ett objekt med Höjd {0}, Bredd {1}, Längd {2} = {3}",
            lådaCheck2.höjd, lådaCheck2.bredd, lådaCheck2.längd, LådList.Contains(lådaCheck2, new LådaSameVolume()));

            Console.ReadKey();
        }

        public static void Display(LådaCollection lådaList)
        {
            Console.WriteLine("\nHöjd\tLängd\tBredd\tHash code");

            foreach (Låda låda in lådaList)
            {
                Console.WriteLine($"{låda.höjd.ToString()}\t{låda.längd.ToString()}\t{låda.bredd.ToString()}" +
                    $"\t{låda.GetHashCode().ToString()}");
            }
        }
    }
}
