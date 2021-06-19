using System;
using BenchmarkDotNet.Running;
namespace play_csharp
{
    using StringMemory;

    partial class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<StringExplained>();

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
                case 4:
                    OutputHumanizerPackageConcepts();
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    Console.ReadLine();
                    break;
            }
        }
    }
}