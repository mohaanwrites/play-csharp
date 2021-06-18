using System;

namespace MasteringCSharp
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

                default:
                    Console.WriteLine("Invalid choice");
                    Console.ReadLine();
                    break;
            }
        }
    }
}