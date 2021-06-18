using System;

namespace play_csharp
{
    partial class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int choice);

            switch (choice)
            {
                case 1:
                    OutputClassConcepts();
                    break;

                case 2:
                    OutputCollectionConcept();
                    break;
                case 3:
                    OutputPropertiesConcept();
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    Console.ReadLine();
                    break;
            }
        }
    }
}