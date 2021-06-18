namespace play_csharp
{
    using p = Properties;
    using System;

    partial class Program
    {
        private static void OutputPropertiesConcept()
        {
            p.Properties p1 = new("Mohaan", "Balakrishnan");
            p1.FirstName = "Mohan";
            //p1.LastName = "Bala"; --read only 
            //p1.FullName = ""; -- read only
            //p1.Identifier = new Guid(); -- init only

            Console.WriteLine($"FirstName: {p1.FirstName}");
            Console.WriteLine($"LastName: {p1.LastName}");
            Console.WriteLine($"FullName: {p1.FullName}");
            Console.WriteLine($"Identifier: {p1.Identifier}");
        }
    }
}