using System;
using MasteringCSharp.Collections;

namespace MasteringCSharp
{
    partial class Program
    {
        private static void OutputCollectionConcept()
        {
            ToLookupExplained c1 = new ToLookupExplained();
            foreach (var str in c1.DoFilter(5))
            {
                Console.WriteLine(str);
            }

            foreach (var str in c1.GetRange(1, 4))
            {
                Console.WriteLine(str);
            }
        }
    }
}