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

            // Adding object with the same dimensions
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

            if (LådList.Contains(lådaCheck))
            {
                Console.WriteLine("\nCollection innehåller ett objekt med Höjd {0}, Bredd {1}, Längd {2}",
                lådaCheck.höjd, lådaCheck.bredd, lådaCheck.längd);
            }
            else
            {
                Console.WriteLine("\nCollection innehåller inte ett objekt med Höjd {0}, Bredd {1}, Längd {2}",
                lådaCheck.höjd, lådaCheck.bredd, lådaCheck.längd);
            }

            Console.ReadKey();
        }

        public static void Display(LådaCollection lådaList)
        {
            Console.WriteLine("\nHöjd\tLängd\tBredd\tHash code");

            foreach (Låda låda in lådaList)
            {
                Console.WriteLine($"{låda.höjd}\t{låda.längd}\t{låda.bredd}\t{låda.GetHashCode().ToString()}");
            }
        }
    }
}
